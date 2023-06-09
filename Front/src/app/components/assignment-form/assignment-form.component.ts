import { Component, EventEmitter, Input, Output, SimpleChanges } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-assignment-form',
  templateUrl: './assignment-form.component.html',
  styleUrls: ['./assignment-form.component.scss']
})
export class AssignmentFormComponent {


  myForm!: FormGroup;
  @Output() submitForm = new EventEmitter();
  @Input() formAssignment: any;

  constructor() { }

  ngOnInit(): void {
    this.myForm = new FormGroup({
      id: new FormControl(this.formAssignment.id),
      projectId: new FormControl(this.formAssignment.projectId),
      userId: new FormControl(this.formAssignment.userId, Validators.required),
      state: new FormControl(this.formAssignment.state, Validators.required),
      description: new FormControl(this.formAssignment.description, [Validators.required, Validators.minLength(3)]),
      title: new FormControl(this.formAssignment.title, [Validators.required, Validators.minLength(3)])
    });
  }

  ngOnChanges(changes: SimpleChanges) {
    if (changes['formAssignment'] && this.myForm) {
      console.log(this.formAssignment);
      this.myForm.setValue({
        id: this.formAssignment.id,
        projectId: this.formAssignment.projectId,
        state: this.formAssignment.state,
        userId: this.formAssignment.userId,
        description: this.formAssignment.description,
        title: this.formAssignment.title
      }
      );
    }
  }

  onSubmit() {
    this.submitForm.emit(this.myForm.value);
  }

}
