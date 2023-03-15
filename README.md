# Treehacks Hackathon 2023: Blood Divers VR Educational Experience

## Goal

Our team views VR as a vital tool for education and in this project we wanted to explore how to make this a more engaging experience. It has been shown through studies that VR enhances learning and students who use VR to visualize complex topics perform better [1]. In this project, we aimed to create an experience that takes this further and incorporates feedback from biosensors into the VR experience and shows the effects of the heart rate on the blood vessels through an immersive and interactive learning tool.

## Inspiration

We wanted to work with VR as we are all a part of Stanford XR, the extended reality club at Stanford. All of us are deeply interested in meaningful applications of VR, especially in education. We chose to make an interactive VR experience on blood vessels to teach students about vascular health. While there are many VR educational games out there, we took our experience a step further by incorporating a heart rate monitor via the Arduino to simulate their bloodstream in-game, making it more personalized and applicable to the player.

## What it does

Blood Divers allows the player to swim around inside their bloodstream using swimming gestures and learn about different types of blood cells as well as the process of endothelial regeneration (repairing the inner membrane of the blood vessels) by directly grabbing endothelial progenitor cells, stimulating their splitting nature, and engaging in repairing the damaged area of the vascular wall themselves. The blood flow reacts to heart rate data collected by the Arduino via a heart rate sensor attached to the user's finger.

## How we built it

### VR

We developed the experience using Unity and the XR Interaction Toolkit for the Oculus Quest. Some of the interactions we created include duplicating cells by "pulling in half" with both hands and navigating using a swimming motion. We designed these interactions and the visuals to appeal to a young audience.

### Environment

We modeled and animated each asset from scratch using Blender.

### Arduino & heart rate sensor

We created the hardware component using an Arduino Uno, the HW-502 heartrate monitor, and custom circuitry to filter and amplify the signal. To measure the heart rate, we used a method similar to a PPG (photoplethysmography) where an IR-led light is shone through the finger and we measured the light transmission through the tissue. The HW-502 provided the IR LED and photodetector but the outputting signal was too noisy, so we built a series of amplifiers and low-pass filters to clean up the signal. This was then read into the Arduino using analog input and the BPM was calculated by checking peaks within a timeframe. Finally, we transmitted this data to the Unity project using UART communication.

## Challenges we ran into
We had challenges with converting assets and modifier animations in Blender to Unity. We also faced multiple Unity crashes and errors.
Arduino

When we picked the heart rate monitor to be the focus of the hardware, we weren't aware of how noisy the signal from the sensor would be. In reality, the sensor provided no filtering of noise. Therefore, we had to perform significant research and work on building the circuit.

## Accomplishments that we're proud of

We're proud of how far we've come as a team in turning our idea into reality during TreeHacks.

## What we learned

We learned a lot about combining VR and Arduino technologies to enhance the educational experience. We learned more about how to create a series of circuit filters. We also gained more knowledge about VR development in Unity, collaborating with each other using Git, and the wonders of our bloodstream.

## What's next for Blood Divers
More educational components on different conditions/diseases like plaque buildup in high cholesterol, anemia, sickle cell disease, and cancer

Optimize the experience (animation, blood cells generation)

Get a higher-quality heart rate monitor/sensor to more accurately track and represent the player's heart rate.

## Links
Our GitHub Repo for the project is here: https://github.com/StevenLe2012/treehacks-hackathon-23

Devpost project is here: https://devpost.com/software/blood-vessel-experience

Treehacks overview: https://treehacks-2023.devpost.com/
