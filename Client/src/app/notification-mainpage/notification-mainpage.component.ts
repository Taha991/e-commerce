import { Component, ElementRef, Renderer2 } from '@angular/core';

@Component({
  selector: 'app-notification-mainpage',
  templateUrl: './notification-mainpage.component.html',
  styleUrls: ['./notification-mainpage.component.css']
})
export class NotificationMainpageComponent {
  constructor(private renderer: Renderer2, private el: ElementRef) {}

  closeNotification(): void {
    const notificationToast = this.el.nativeElement.querySelector('[data-toast]');
    if (notificationToast) {
      this.renderer.addClass(notificationToast, 'closed');
    }
  }
  // Function to handle the closing of the modal
  closeModal(): void {

    const modal = document.querySelector('[data-modal]');
    if (modal) {
      modal.classList.add('closed');
    }
  }
}
