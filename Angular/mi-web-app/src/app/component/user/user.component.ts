import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {

  constructor() { }

  visible = false;

  ngOnInit(): void {
    setTimeout(() => {
      this.visible = true;
    }, 3000);
  }

  users = ['Luis', 'Fernando', 'Maria'];
  username = '';

  onAddUser = ()=>{
    this.users.push(this.username);
    this.username = '';
  }

}
