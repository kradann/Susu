#!/bin/sh

teamsadat=`cat teams.dat`
hallgato=`cat hallgato.dat`


case $1 in
	"-lista")
		IFS='

'
		for i in $teamsadat
		do
			if test "$2" = `echo $i | cut -d"," -f3`
			then
				echo $i | cut -d"," -f1
			fi
		done
	;;
	"-hallgato")
		IFS='

'
		for i in $hallgato
		do
			if test "$2" = `echo "$i" | cut -d"," -f2`
			then
				kodok=`echo "$i" | cut -d"," -f3-`
				IFS=','
				for j in $kodok
				do
					IFS='
'
						for k in $teamsadat
						do
							if test "$j" = `echo "$k" | cut -d"," -f2`
							then
								echo "$k" | cut -d"," -f1
							fi
						done
				done
			fi
		done	
	;;
	"-sok")
		max=0
		tanar=""
		IFS='

	
'
		ered=""
		tanarok_natur=`echo "$teamsadat" | cut -d"," -f3`
		tanarok=`echo "$teamsadat" | cut -d"," -f3 | sort -u`
		for i in $tanarok
		do
			count=0
			for j in $tanarok_natur
			do
				if test "$i" = `echo "$j"`
				then
					count=$((count+1))
				fi		
			done
			if [ "$count" -gt "$max" ]
			then
				max=$count
				ered="$i"
			fi
		done
		echo "$ered"
		
			
	;;
esac
