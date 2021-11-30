{\rtf1\ansi\ansicpg1252\cocoartf2580
\cocoatextscaling0\cocoaplatform0{\fonttbl\f0\fmodern\fcharset0 Courier;}
{\colortbl;\red255\green255\blue255;\red147\green0\blue147;\red250\green251\blue254;\red42\green44\blue51;
\red50\green94\blue238;\red178\green113\blue6;\red14\green112\blue173;}
{\*\expandedcolortbl;;\cssrgb\c65098\c14902\c64314;\cssrgb\c98431\c98824\c99608;\cssrgb\c21961\c22745\c25882;
\cssrgb\c25098\c47059\c94902;\cssrgb\c75686\c51765\c392;\cssrgb\c392\c51765\c73333;}
{\*\listtable{\list\listtemplateid1\listhybrid{\listlevel\levelnfc23\levelnfcn23\leveljc0\leveljcn0\levelfollow0\levelstartat1\levelspace360\levelindent0{\*\levelmarker \{none\}}{\leveltext\leveltemplateid1\'00;}{\levelnumbers;}\fi-360\li720\lin720 }{\listname ;}\listid1}}
{\*\listoverridetable{\listoverride\listid1\listoverridecount0\ls1}}
\paperw11900\paperh16840\margl1440\margr1440\vieww11520\viewh8400\viewkind0
\deftab720
\pard\tx220\tx720\pardeftab720\li720\fi-720\sl510\partightenfactor0
\ls1\ilvl0
\f0\fs30 \cf2 \cb3 		\expnd0\expndtw0\kerning0
\outl0\strokewidth0 \strokec2 using\cf4 \strokec4  System;\cb1 \uc0\u8232 \cb3 2\cb1 \uc0\u8232 \u8232 \cb3 3\cb1 \uc0\u8232 \cf2 \cb3 \strokec2 static\cf4 \strokec4  \cf2 \strokec2 class\cf4 \strokec4  \cf5 \strokec5 QuestLogic\cf4 \cb1 \strokec4 \uc0\u8232 \cb3 4\cb1 \uc0\u8232 \cb3 \{\cb1 \uc0\u8232 \cb3 5\cb1 \uc0\u8232 \cb3     \cf2 \strokec2 public\cf4 \strokec4  \cf2 \strokec2 static\cf4 \strokec4  \cf6 \strokec6 bool\cf4 \strokec4  \cf5 \strokec5 CanFastAttack\cf4 \strokec4 (\cf6 \strokec6 bool\cf4 \strokec4  knightIsAwake)\cb1 \uc0\u8232 \cb3 6\cb1 \uc0\u8232 \cb3     \{\cb1 \uc0\u8232 \cb3 7\cb1 \uc0\u8232 \cb3         \cf2 \strokec2 var\cf4 \strokec4  attack = knightIsAwake ? \cf7 \strokec7 false\cf4 \strokec4  : \cf7 \strokec7 true\cf4 \strokec4 ; \cb1 \uc0\u8232 \cb3 8\cb1 \uc0\u8232 \cb3         \cf2 \strokec2 return\cf4 \strokec4  attack;\cb1 \uc0\u8232 \cb3 9\cb1 \uc0\u8232 \cb3     \}\cb1 \uc0\u8232 \cb3 10\cb1 \uc0\u8232 \u8232 \cb3 11\cb1 \uc0\u8232 \cb3     \cf2 \strokec2 public\cf4 \strokec4  \cf2 \strokec2 static\cf4 \strokec4  \cf6 \strokec6 bool\cf4 \strokec4  \cf5 \strokec5 CanSpy\cf4 \strokec4 (\cf6 \strokec6 bool\cf4 \strokec4  knightIsAwake, \cf6 \strokec6 bool\cf4 \strokec4  archerIsAwake, \cf6 \strokec6 bool\cf4 \strokec4  prisonerIsAwake)\cb1 \uc0\u8232 \cb3 12\cb1 \uc0\u8232 \cb3     \{\cb1 \uc0\u8232 \cb3 13\cb1 \uc0\u8232 \cb3         \cf2 \strokec2 if\cf4 \strokec4 (knightIsAwake || archerIsAwake || prisonerIsAwake) \{\cb1 \uc0\u8232 \cb3 14\cb1 \uc0\u8232 \cb3             \cf2 \strokec2 return\cf4 \strokec4  \cf7 \strokec7 true\cf4 \strokec4 ;\cb1 \uc0\u8232 \cb3 15\cb1 \uc0\u8232 \cb3         \}\cb1 \uc0\u8232 \cb3 16\cb1 \uc0\u8232 \cb3     \cb1 \uc0\u8232 \cb3 17\cb1 \uc0\u8232 \cb3         \cf2 \strokec2 return\cf4 \strokec4  \cf7 \strokec7 false\cf4 \strokec4 ;\cb1 \uc0\u8232 \cb3 18\cb1 \uc0\u8232 \cb3     \}\cb1 \uc0\u8232 \cb3 19\cb1 \uc0\u8232 \u8232 \cb3 20\cb1 \uc0\u8232 \cb3     \cf2 \strokec2 public\cf4 \strokec4  \cf2 \strokec2 static\cf4 \strokec4  \cf6 \strokec6 bool\cf4 \strokec4  \cf5 \strokec5 CanSignalPrisoner\cf4 \strokec4 (\cf6 \strokec6 bool\cf4 \strokec4  archerIsAwake, \cf6 \strokec6 bool\cf4 \strokec4  prisonerIsAwake)\cb1 \uc0\u8232 \cb3 21\cb1 \uc0\u8232 \cb3     \{\cb1 \uc0\u8232 \cb3 22\cb1 \uc0\u8232 \cb3         \cf2 \strokec2 if\cf4 \strokec4 (archerIsAwake && prisonerIsAwake)\cb1 \uc0\u8232 \cb3 23\cb1 \uc0\u8232 \cb3         \{\cb1 \uc0\u8232 \cb3 24\cb1 \uc0\u8232 \cb3             \cf2 \strokec2 return\cf4 \strokec4  \cf7 \strokec7 false\cf4 \strokec4 ;\cb1 \uc0\u8232 \cb3 25\cb1 \uc0\u8232 \cb3         \} \cf2 \strokec2 else\cf4 \strokec4  \cf2 \strokec2 if\cf4 \strokec4 (!archerIsAwake && prisonerIsAwake)\cb1 \uc0\u8232 \cb3 26\cb1 \uc0\u8232 \cb3         \{\cb1 \uc0\u8232 \cb3 27\cb1 \uc0\u8232 \cb3             \cf2 \strokec2 return\cf4 \strokec4  \cf7 \strokec7 true\cf4 \strokec4 ;\cb1 \uc0\u8232 \cb3 28\cb1 \uc0\u8232 \cb3         \}\cb1 \uc0\u8232 \cb3 29\cb1 \uc0\u8232 \cb3     \cb1 \uc0\u8232 \cb3 30\cb1 \uc0\u8232 \cb3         \cf2 \strokec2 return\cf4 \strokec4  \cf7 \strokec7 false\cf4 \strokec4 ;\cb1 \uc0\u8232 \cb3 31\cb1 \uc0\u8232 \cb3     \}\cb1 \uc0\u8232 \cb3 32\cb1 \uc0\u8232 \u8232 \cb3 33\cb1 \uc0\u8232 \cb3     \cf2 \strokec2 public\cf4 \strokec4  \cf2 \strokec2 static\cf4 \strokec4  \cf6 \strokec6 bool\cf4 \strokec4  \cf5 \strokec5 CanFreePrisoner\cf4 \strokec4 (\cf6 \strokec6 bool\cf4 \strokec4  knightIsAwake, \cf6 \strokec6 bool\cf4 \strokec4  archerIsAwake, \cf6 \strokec6 bool\cf4 \strokec4  prisonerIsAwake, \cf6 \strokec6 bool\cf4 \strokec4  petDogIsPresent)\cb1 \uc0\u8232 \cb3 34\cb1 \uc0\u8232 \cb3     \{\cb1 \uc0\u8232 \cb3 35\cb1 \uc0\u8232 \cb3         \cf2 \strokec2 if\cf4 \strokec4 (petDogIsPresent && !archerIsAwake)\cb1 \uc0\u8232 \cb3 36\cb1 \uc0\u8232 \cb3         \{\cb1 \uc0\u8232 \cb3 37\cb1 \uc0\u8232 \cb3             \cf2 \strokec2 return\cf4 \strokec4  \cf7 \strokec7 true\cf4 \strokec4 ;\cb1 \uc0\u8232 \cb3 38\cb1 \uc0\u8232 \cb3         \} \cf2 \strokec2 else\cf4 \strokec4  \cf2 \strokec2 if\cf4 \strokec4 (!petDogIsPresent && prisonerIsAwake && !archerIsAwake && !knightIsAwake)\cb1 \uc0\u8232 \cb3 39\cb1 \uc0\u8232 \cb3         \{\cb1 \uc0\u8232 \cb3 40\cb1 \uc0\u8232 \cb3             \cf2 \strokec2 return\cf4 \strokec4  \cf7 \strokec7 true\cf4 \strokec4 ;\cb1 \uc0\u8232 \cb3 41\cb1 \uc0\u8232 \cb3         \}\cb1 \uc0\u8232 \cb3 42\cb1 \uc0\u8232 \u8232 \cb3 43\cb1 \uc0\u8232 \cb3         \cf2 \strokec2 return\cf4 \strokec4  \cf7 \strokec7 false\cf4 \strokec4 ;\cb1 \uc0\u8232 \cb3 44\cb1 \uc0\u8232 \cb3     \}\cb1 \uc0\u8232 \cb3 45\cb1 \uc0\u8232 \cb3 \}\cb1 \uc0\u8232 \cb3 46\cb1 \uc0\u8232 
\fs28 \cb3 \
}