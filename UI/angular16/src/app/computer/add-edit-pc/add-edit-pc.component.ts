import { Component, OnInit, Input } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-add-edit-pc',
  templateUrl: './add-edit-pc.component.html',
  styleUrls: ['./add-edit-pc.component.css']
})
export class AddEditPcComponent implements OnInit {

  constructor(private service:SharedService){ }

  @Input() pc:any;
  id: number = 0;
  placa_mae: string = "";
  processador: string = "";
  memoria_ram: number = 0;
  armazenamento: number = 0;
  gpu: string = "";
  fonte: string = "";


  ngOnInit(): void { 
    this.id = this.pc.id;
    this.placa_mae = this.pc.placa_mae;
    this.processador = this.pc.processador;
    this.memoria_ram = this.pc.memoria_ram;
    this.armazenamento = this.pc.armazenamento;
    this.gpu = this.pc.gpu;
    this.fonte = this.pc.fonte;
  }

  addComputer(){
    var val = {id: this.pc.id,
      placa_mae: this.pc.placa_mae,
      processador: this.pc.processador,
      memoria_ram: this.pc.memoria_ram,
      armazenamento: this.pc.armazenamento,
      gpu: this.pc.gpu,
      fonte: this.pc.fonte
    };
    this.service.addComputer(val).subscribe(res=>{
      alert(res.toString());
    });
  }

  updateComputer(){
    var val = {id: this.pc.id,
      placa_mae: this.pc.placa_mae,
      processador: this.pc.processador,
      memoria_ram: this.pc.memoria_ram,
      armazenamento: this.pc.armazenamento,
      gpu: this.pc.gpu,
      fonte: this.pc.fonte
    };
    this.service.updateComputer(val).subscribe(res=>{
      alert(res.toString());
    });
  }

}
