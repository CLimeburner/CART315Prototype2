#Final Prototype Design Journal

For this final version of my prototype, there were a couple major points I wanted to refine just a little further, as well as several much smaller questions of polish. To restate the goal of this project, it was to develop a realistic queue experience that could keep players engaged as well as conveying the backstory for the hypothetical ride that would follow. Importantly, the queue experience also had to take on a "threshold" element, transitioning players from whatever hypothetical outside world they might be coming from and explaining to them how they've found themselves in a cave, embarking on an adventure. This was done both narratively (to mixed success) as well as spatially, as rooms become smaller and more cramped until they transition to the new diegetic cavern space and start opening back up again as guests step into this "new" world.

Over the course of testing, it was determined that the ideal length of time spent at any specific "waypoint" in the queue was somewhere between 30 seconds and two minutes, with longer times being favoured near the detail-rich first three rooms of the queue. Additionally, although players were able to pick up some of the general backstory regarding a mysterious sea creature and some tablets, they were nearly unanimously unable to explain the transition from a museum space to caves. There were some theories that were workable enough (such as secret caves beneath the institution) but none were able to articulate the designed narrative intent, which was a supernatural transformation enacted by the tablets themselves.

To address the first major issue of pacing, rather than only adjust the waypoint length of time, this final version reduced waypoint time slightly while also adding additional waypoints, particularly in the earlier rooms. This has the overall effect of lengthening the experience, but giving guests more to look at that they would have had to walk by previously. This should help reduce boredom while also heightening narrative understanding.

To address the second issue, it was difficult to know how best to resolve it. There were several ideas that were plausible but required the creation of assets, for which I didn't have the time (such as rear "projected" animations in the hallway windows of researchers being attacked in their offices by otherworldly creatures), and so the solution I've implemented in this version is to create a second bright green light by the tablets themselves, attempting to highlight their effect on the transformation of the following hallway, and then pulsed the two lights in a slow rhythmic pattern, to indicate more dynamic movement where a realistic built space would not be able to otherwise move or change.

On smaller notes, museum content was reviewed to fix typos, a small portion of aberrant overlapping geometry was removed, the camera was locked in a reasonable arc so as to avoid control inversion, and on-screen instructions were removed, as this will be exhibited in the DCART end-of-year show where these instructions will be on a placard next to the mouse. These were all small but noticeable issues that playtesters had pointed out and which were easy and appropriate to fix as part of the final revisions.

Finally, another round was spent on trying to improve framerate by adjusting the lighting. Progress was made in understanding the source of the issue (shadow rendering, number of pixel light sources, texture resolution, batching, etc) however no practical solution presented itself in the time available and so no changes were implemented to the final lighting rendering. I do think it's quite possible that with further time and revision, the lighting performance could easily be improved, once I have a better understand the underlying principles.

To download the final built executable: https://climeburner.itch.io/virtual-queue

## Revised Prototype Design Journal

Revisiting this prototype for my revised choice, it's worth restating the question at the core of the experience: how can one create a broadly passive experience that is both entertaining and conveys diegetic context for a following experience? Reviewing the feedback from the prior playtest, boredom seems to have been the least of concerns, with most playtesters expressing excitement and curiosity regarding the narrative elements presented, however few were able to identify the specific generic niche of the queue design, and none were able to accurately recount explicit narrative details. This is likely due to the design existing as a form of queue experience, meaning it was intended to be consumed at a much slower pace than the initial prototype. Seeing as playtesters were far from bored with the 5-minute version, I think it's safe to say I can lengthen the timespan at the risk of some boredom, in the hopes that guests are able to gather more of the backstory. With this in mind, the most significant change to this prototype is the revision of timing cues and waypoints so that the play experience lasts closer to 15 minutes than 5.

Another major point of confusion regarding the narrative related to the lack of definitive ending, with the prototype fading to black. Although the revised version still fades to black, there is now a ride vehicle added to the experience that periodically pulls into the station to take passengers and then departs. This should hopefully give players a clearer sense of what the queue is leading to, as well as make it clear the queue has now ended with their implied embarking on the ride.

Besides these two major changes, several smaller changes have been made to adjust the aesthetics of the experience. The render mode of the generic crowd models has been tweaked to fade more cleanly into the environment, several lights that intentionally flicker were made more pronounced so as to not seem like a bug, the mouse cursor was set to lock and hide during play, and the ability to zoom the view was changed from spacebar to left mouse click to reduce the form factor of equipment needed to interact with the prototype (keyboard is no longer necessary).

Finally, several experiments were undertaken to improve the framerate of the prototype, largely by trying to improve the light rendering. Unfortunately, because of the way the models were originally built and textured, baking light maps proved impractical without re-engineering a lot of the assets and so no changes to lighting performance made it to the final version this week.

Questions for Playtesters:

1) Now that it's longer, did you become bored at any point during the experience?

2) Can you tell what kind of ride follows this queue?

3) As best you can, please try to describe the genre, theme, or backstory of the ride that would follow this queue.

4) Are there any otherwise minor bugs you encountered? (Ex.: typos in graphic text, geometry weirdness, lighting anomalies, etc) Please try to describe their nature and location as specifically as possible so I can track them down.

## Iteration Feedback Reflection

Reviewing the feedback for this iteration, there are some key observations that stand out. First, broad consensus is that this version, 3-4 times as long as the original, does start to drag in places. However, importantly, boredom seems to set in in specific places where there is less to look at. Additionally, playtesters have a better sense of the backstory to the queue and ride, but are still missing key elements. A potential remedy to these interwoven issues might be to shorten the wait time at individual stops, but increase the number of stops, giving guests the opportunity to read, see, or review more of the environment and backstory.

One particularly thorny issue is that playtesters continue to not be able to explain the transition throughout the queue from museum-like spaces to cave-like spaces. There are some attempted environmental cues in the lighting and audio, but this is tricky because the fundamental design attempts to stay within the realm of what could be physically built. Though I don't anticipate having the time to do this in the next week, "projection mapped" video played on the windows in the "research hallway" could potentially help elucidate the transition more, as well as helping with the aforementioned issues with boredom is selected areas, particularly as playtesters move into the caves. Apropos of this last point, I will also likely be revisiting the last two cave-like spaces to decide if and where to place additional elements to make the wait in those rooms less boring.

Finally, there are a variety of minor technical bugs that the longer wait time in this iteration helped to uncover. This included an element of overlapping geometry, typos within the body text of signs, and the camera not having a maximum for upward tilt, occasionally causing inverted controls. These should all be easily remedied in the next week.

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
