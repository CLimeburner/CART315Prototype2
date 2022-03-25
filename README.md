# Revised Prototype Design Journal

Revisiting this prototype for my revised choice, it's worth restating the question at the core of the experience: how can one create a broadly passive experience that is both entertaining and conveys diegetic context for a following experience? Reviewing the feedback from the prior playtest, boredom seems to have been the least of concerns, with most playtesters expressing excitement and curiosity regarding the narrative elements presented, however few were able to identify the specific generic niche of the queue design, and none were able to accurately recount explicit narrative details. This is likely due to the design existing as a form of queue experience, meaning it was intended to be consumed at a much slower pace than the initial prototype. Seeing as playtesters were far from bored with the 5-minute version, I think it's safe to say I can lengthen the timespan at the risk of some boredom, in the hopes that guests are able to gather more of the backstory. With this in mind, the most significant change to this prototype is the revision of timing cues and waypoints so that the play experience lasts closer to 15 minutes than 5.

Another major point of confusion regarding the narrative related to the lack of definitive ending, with the prototype fading to black. Although the revised version still fades to black, there is now a ride vehicle added to the experience that periodically pulls into the station to take passengers and then departs. This should hopefully give players a clearer sense of what the queue is leading to, as well as make it clear the queue has now ended with their implied embarking on the ride.

Besides these two major changes, several smaller changes have been made to adjust the aesthetics of the experience. The render mode of the generic crowd models has been tweaked to fade more cleanly into the environment, several lights that intentionally flicker were made more pronounced so as to not seem like a bug, the mouse cursor was set to lock and hide during play, and the ability to zoom the view was changed from spacebar to left mouse click to reduce the form factor of equipment needed to interact with the prototype (keyboard is no longer necessary).

Finally, several experiments were undertaken to improve the framerate of the prototype, largely by trying to improve the light rendering. Unfortunately, because of the way the models were originally built and textured, baking light maps proved impractical without re-engineering a lot of the assets and so no changes to lighting performance made it to the final version this week.

Questions for Playtesters:

1) Now that it's longer, did you become bored at any point during the experience?

2) Can you tell what kind of ride follows this queue?

3) As best you can, please try to describe the genre, theme, or backstory of the ride that would follow this queue.

4) Are there any otherwise minor bugs you encountered? (Ex.: typos in graphic text, geometry weirdness, lighting anomalies, etc) Please try to describe their nature and location as specifically as possible so I can track them down.

## Original Prototype 2 Design Journal

This week's prototype builds upon an independent study project I began last semester. More specifically, the independent study project was carried out to explore methods of environmental storytelling, particularly within the context of a theme park queue. Of note, theme park queues are often more than simply an efficient way to direct crowds of people; rather, they also act as a vehicle for backstory, transitioning guests from the outside theming of the park, to the interior diegetic world within which the ride exists. Bearing this in mind, the hypothesis explored, both by that initial independent study project, and this prototype that builds upon it, is if the provided information and environment 1) prevents guests from becoming bored while they wait and 2) if the information, fleeting and incomplete as it is, is sufficient for guests to understand the genre, theme, and broad context for the ride upon which they are about to embark.

At the end of last semester, the experience was playable, however I did not have sufficient time to add more dynamic elements that I had otherwise initially planned for. This includes flickering light effects, audio, and models that move within the environment to create great visual interest as well as simulate the experience of an actual theme park queue. The initial experience was also designed to be played over the course of half an hour, whereas this version has been tweaked to only require five minutes. Finally, a handful of aspects have been adjusted based on best practices information acquired in this class (such as using FixedUpdate).

Note: Though the modelling and graphic design for this project is wholly original, many of the textures, photographs, and audio files used to flesh out the experience are sourced from the internet. For a complete list of asset sources, please refer to AssetSources.PDF.

Original Questions for Playtesters:

1) Did you become bored at any point during the experience?

2) Did you have a favourite part of the experience? If so, which part and why?

3) Did this experience make you want to ride the attraction that would follow it?

4) As best you can, please try to describe the genre, theme, or backstory of the ride that would follow this queue.

5) This prototype has known frame rate issues. Could you please outline, as specifically as possible, any issues you may have had with lag or jittery frame rate.  

## Original Feedback Reflection

In considering the successes or failures of this prototype, we must remember the joint questions I hoped to answer: 1) "Does the environmental design keep guests' attention?"" and 2) "Does the design convey the "ride" backstory?" To this first question, it would seem this prototype was very successful in keeping the attention of those who played it, with the most lukewarm response being, "waiting in line when the line wasn't moving was not the most entertaining thing, but there was still a lot to study in the environment." Indeed, the majority of players actively expressed excitement and curiosity to spend more time with the displays to learn more about the backstory of the experience.

To my second question about conveying the backstory, I'd say this prototype was less successful. Broadly, players identified the genre, using keywords such as mystery, thriller, horror, and spooky, and identified some key narrative elements with keywords such as Cthulhu and eldritch, but this experience has a very explicit story both diegetically and meta-diegetically* and both of these narrative threads seem to have been lost in translation, in part due to how short the experience is. Additionally, without context, it seems to be a coin flip as to whether or not players understand they are in a theme park queue. Several players didn't realize there was supposed to be an implied ride at the end of the queue, a couple theorized the following ride might be a dark ride or flume (with specific reference to Universal Studio's Jurrasic Park ride), and only a couple recognized the intended roller coaster track at the end of the experience.

To respond to these failures of communication, the ride system can likely be better communicated by modelling roller coaster ride vehicles that pass through the station several times while guests traverse the large final room, providing foreshadowing of where the queue is going before fading to black. To address the communication of narrative, I think this can be easily solved by leveraging the excitement and curiosity expressed in response to my first line of inquiry. Since players felt an abundance of interest and curiosity to explore the environment, it would seem the easy answer is to simply provide more stopping points in the queue. Particularly in the museum exhibit, this would give players more opportunities to read plaques and absorb the relationship between scenic elements.

One final observation was that going into this prototype, there were known framerate issues, though these issues were not nearly as reflected amongst playtesters. About half of playtesters commented that they experienced no framerate issues, and during the live playtest, it appeared the game was rendering with different ambient lighting conditions. It woudl still seem this is a concern, though not nearly as strong of one as I'd anticipated and so this will be a secondary goal to improve performance, likely by exploring how Unity is specifically rendering both the lighting and models of the prototype.

*This is to say, there are two levels of diegesis at play in this experience: the narrative of the guests passing through the space, and the backstory that makes the space what it is. In this case, the former relates to the transition from museum to caves while the later pertains to the whale themes. Both of these were noticed but not well understood by players.
