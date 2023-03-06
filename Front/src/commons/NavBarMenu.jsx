import React from 'react'
import { ColorModeSwitcher } from '../ColorModeSwitcher';
import { FaBars } from "react-icons/fa"

import {
    Avatar,
    ChakraProvider,
    Divider,
    Flex,
    Heading,
    theme,
    Text,
    IconButton,
  } from '@chakra-ui/react';

  

  
const NavBarMenu = () => {
  return (
    <>
        <Flex 
            pos="sticky"
            left="5"
            h="95vh"
            boxShadow="0 4px 12px 0 rgba(0,0,0,0.05)"
            w="200px"
            flexDir="column"
            justifyContent="space-between"
        >
            <Flex p="5%" flexDir="Column" alignItems="flex-start" as="nav">
                <IconButton background="none" mt={5} _hover={{ background:'none'}} icon={<FaBars/>} onClick={ () => {}}/> {/* aqui quede */}
            </Flex>
            
            <Flex marginTop={10}>
                <ChakraProvider theme={theme}>
                    <ColorModeSwitcher/>
                </ChakraProvider> 
            </Flex>
            
            <Flex
                p="5%"
                flexDir="column"
                w="100%"
                alignItems="flex-start"
                mb={4}
            >
                <Divider/>
                <Flex mt={4} align="center">
                    <Avatar h="70px" w="70px" src='avatar-1.png' boxShadow="12px 4px 12px 0 rgba(0,0,0,0.05)"/>
                    <Flex flexDir="column" ml={4}>
                        <Heading as="h3" size="sm">Nombre apellido</Heading>
                        <Text color="gray">ROL</Text>
                    </Flex>
                </Flex>

            </Flex>

        </Flex>
        
    

    </>
  )
}

export default NavBarMenu