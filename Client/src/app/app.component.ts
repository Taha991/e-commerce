import { HttpClient } from '@angular/common/http';
import { Component , OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'Client';
  constructor(private http:HttpClient)
  {

  }
  products:any[]=[];
  ngOnInit(): void {
this.http.get("https://localhost:7227/api/Mens").subscribe({
  next :(response:any) => this.products = response.data,
  error : error => console.log(error),
  complete : ()=>{
    console.log("Req Complete" + this.products)
  console.log()}

})
  }
}
