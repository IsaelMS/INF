<mxfile host="app.diagrams.net" modified="2023-02-25T23:46:11.746Z" agent="5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/110.0.0.0 Safari/537.36 Edg/110.0.1587.50" etag="fa2il3IYb6vEKKn6_bZj" version="20.8.23" type="github">
  <diagram id="3I0p2mTRq_sJxFSzwgRq" name="Page-1">
    <mxGraphModel dx="1120" dy="484" grid="1" gridSize="10" guides="1" tooltips="1" connect="1" arrows="1" fold="1" page="1" pageScale="1" pageWidth="827" pageHeight="1169" math="0" shadow="0">
      <root>
        <mxCell id="0" />
        <mxCell id="1" parent="0" />
        <mxCell id="d2mRjUpL5fEEVMCh5pt4-31" value="Mouse" style="swimlane;fontStyle=1;align=center;verticalAlign=top;childLayout=stackLayout;horizontal=1;startSize=26;horizontalStack=0;resizeParent=1;resizeParentMax=0;resizeLast=0;collapsible=1;marginBottom=0;fontSize=14;" parent="1" vertex="1">
          <mxGeometry x="224" y="40" width="380" height="424" as="geometry" />
        </mxCell>
        <mxCell id="d2mRjUpL5fEEVMCh5pt4-32" value="- marca : string" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;fontSize=14;" parent="d2mRjUpL5fEEVMCh5pt4-31" vertex="1">
          <mxGeometry y="26" width="380" height="26" as="geometry" />
        </mxCell>
        <mxCell id="d2mRjUpL5fEEVMCh5pt4-43" value="- modelo : string" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;fontSize=14;" parent="d2mRjUpL5fEEVMCh5pt4-31" vertex="1">
          <mxGeometry y="52" width="380" height="26" as="geometry" />
        </mxCell>
        <mxCell id="d2mRjUpL5fEEVMCh5pt4-35" value="- tipo : string {Tipos permitidos: Normal y Ergonomico}" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;fontSize=14;" parent="d2mRjUpL5fEEVMCh5pt4-31" vertex="1">
          <mxGeometry y="78" width="380" height="26" as="geometry" />
        </mxCell>
        <mxCell id="d2mRjUpL5fEEVMCh5pt4-36" value="- color : string {Colores permitidos: Rojo, Verde, Azul}" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;fontSize=14;" parent="d2mRjUpL5fEEVMCh5pt4-31" vertex="1">
          <mxGeometry y="104" width="380" height="26" as="geometry" />
        </mxCell>
        <mxCell id="d2mRjUpL5fEEVMCh5pt4-37" value="- ergonomico : boolean" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;fontSize=14;" parent="d2mRjUpL5fEEVMCh5pt4-31" vertex="1">
          <mxGeometry y="130" width="380" height="26" as="geometry" />
        </mxCell>
        <mxCell id="d2mRjUpL5fEEVMCh5pt4-41" value="- precio : float" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;fontSize=14;" parent="d2mRjUpL5fEEVMCh5pt4-31" vertex="1">
          <mxGeometry y="156" width="380" height="26" as="geometry" />
        </mxCell>
        <mxCell id="d2mRjUpL5fEEVMCh5pt4-33" value="" style="line;strokeWidth=1;fillColor=none;align=left;verticalAlign=middle;spacingTop=-1;spacingLeft=3;spacingRight=3;rotatable=0;labelPosition=right;points=[];portConstraint=eastwest;fontSize=14;" parent="d2mRjUpL5fEEVMCh5pt4-31" vertex="1">
          <mxGeometry y="182" width="380" height="8" as="geometry" />
        </mxCell>
        <mxCell id="d2mRjUpL5fEEVMCh5pt4-34" value="+ seleccionar(string bloqueTexto) : boolean" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;fontSize=14;" parent="d2mRjUpL5fEEVMCh5pt4-31" vertex="1">
          <mxGeometry y="190" width="380" height="26" as="geometry" />
        </mxCell>
        <mxCell id="d2mRjUpL5fEEVMCh5pt4-38" value="+ clickDerecho() : boolean" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;fontSize=14;" parent="d2mRjUpL5fEEVMCh5pt4-31" vertex="1">
          <mxGeometry y="216" width="380" height="26" as="geometry" />
        </mxCell>
        <mxCell id="d2mRjUpL5fEEVMCh5pt4-39" value="+ clickIzquierdo() : boolean" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;fontSize=14;" parent="d2mRjUpL5fEEVMCh5pt4-31" vertex="1">
          <mxGeometry y="242" width="380" height="26" as="geometry" />
        </mxCell>
        <mxCell id="d2mRjUpL5fEEVMCh5pt4-42" value="+ arrastrar(string bloqueTexto) : string" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;fontSize=14;" parent="d2mRjUpL5fEEVMCh5pt4-31" vertex="1">
          <mxGeometry y="268" width="380" height="26" as="geometry" />
        </mxCell>
        <mxCell id="d2mRjUpL5fEEVMCh5pt4-44" value="+ getPrecio() : float" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;fontSize=14;" parent="d2mRjUpL5fEEVMCh5pt4-31" vertex="1">
          <mxGeometry y="294" width="380" height="26" as="geometry" />
        </mxCell>
        <mxCell id="d2mRjUpL5fEEVMCh5pt4-45" value="+ setPrecio(float precio) : void" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;fontSize=14;" parent="d2mRjUpL5fEEVMCh5pt4-31" vertex="1">
          <mxGeometry y="320" width="380" height="26" as="geometry" />
        </mxCell>
        <mxCell id="d2mRjUpL5fEEVMCh5pt4-46" value="+ getColor() : string" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;fontSize=14;" parent="d2mRjUpL5fEEVMCh5pt4-31" vertex="1">
          <mxGeometry y="346" width="380" height="26" as="geometry" />
        </mxCell>
        <mxCell id="d2mRjUpL5fEEVMCh5pt4-47" value="+ setColor(string color) : void" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;fontSize=14;" parent="d2mRjUpL5fEEVMCh5pt4-31" vertex="1">
          <mxGeometry y="372" width="380" height="26" as="geometry" />
        </mxCell>
        <mxCell id="mRydxMA_sjRoWrlnV-E4-1" value="+ desplegarInformacion() : void" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;fontSize=14;" parent="d2mRjUpL5fEEVMCh5pt4-31" vertex="1">
          <mxGeometry y="398" width="380" height="26" as="geometry" />
        </mxCell>
      </root>
    </mxGraphModel>
  </diagram>
</mxfile>
