#version 330 core

in vec3 finalVel;
in vec3 finalColour;

out vec4 color;

void main() {
    //color = vec4(abs(finalVel), 1.0f);
    color = vec4(1.0f, 1.0f, 1.0f, 1.0f);
}
