import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { MemberListComponent } from './members/member-list/member-list.component';
import { MemberDetalisComponent } from './members/member-detalis/member-detalis.component';
import { ListsComponent } from './lists/lists.component';
import { MessagesComponent } from './messages/messages.component';
import { authGuard } from './_guards/auth.guard';

export const routes: Routes = [
    {path: '', component: HomeComponent},
    {path:'',
        runGuardsAndResolvers:'always',
        canActivate:[authGuard],
        children:[
            {path: 'members', component: MemberListComponent},
            {path: 'members/id', component: MemberDetalisComponent},
            {path: 'messages', component: MessagesComponent},
            {path: 'lists', component: ListsComponent},
           ]
    },
    {path: '**', component: HomeComponent, pathMatch:'full'}
    
];
