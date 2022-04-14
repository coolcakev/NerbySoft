import axios from "axios";
let port="44371";
let domain="localhost"
let host=`https://${domain}:${port}/`
export default class AnnouncementsService {
    static async GetAnnoncments() {
        try {
            let response = await axios.get(`${host}Announsment/GetAnnounsments`);
            return response.data;
        }
        catch (e) {
            console.log(e)
        }

    }
    static async CreateAnnouncement(announcement) {    
        try {                  
            let response = await axios.post(`${host}Announsment/Create`,announcement);   
            return response.data;        
        }
        catch (e) {
            console.log(e)
        }

    } 
    static async UpdateAnnouncement(announcement) {    
        try {                  
            let response = await axios.post(`${host}Announsment/Update`,announcement);     
            
        }
        catch (e) {
            console.log(e)
        }

    } 
    static async DeleteAnnouncement(announcementId) {    
      
        console.log(announcementId);
        try {                  
            let response = await axios.post(`${host}Announsment/Delete/${announcementId}`);           
        }
        catch (e) {
            console.log(e)
        }

    } 
}  