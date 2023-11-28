let contadorProdutos = 1;

function addProdutoNovo() {
    contadorProdutos++;

    let novoId = 'produto' + contadorProdutos;

    $("tbody").append('<tr id="' + novoId + '"> \
        <td> \
            <div class="product"> \
                <img src="https://picsum.photos/100/120" alt="" /> \
                <div class="info"> \
                    <div class="name">Nome do produto</div> \
                    <div class="category">Categoria</div> \
                </div> \
            </div> \
        </td> \
        <td class="valor-produto">R$ 120</td> \
        <td> \
            <div class="qty"> \
                <button onclick="atualizarQuantidade(\'' + novoId + '\', -1)"><i class="bx bx-minus"></i></button> \
                <span>1</span> \
                <button onclick="atualizarQuantidade(\'' + novoId + '\', 1)"><i class="bx bx-plus"></i></button> \
            </div> \
        </td> \
        <td class="total-produto">R$ 120</td> \
        <td> \
            <button class="remove" onclick="removerProduto(\'' + novoId + '\')"><i class="bx bx-x"></i></button> \
        </td> \
    </tr>');

    atualizarResumoCompra();
}

function atualizarQuantidade(id, quantidade) {

    let spanQuantidade = $("#" + id + " .qty span");
    let novaQuantidade = parseInt(spanQuantidade.text()) + quantidade;

    novaQuantidade = novaQuantidade < 0 ? 0 : novaQuantidade;

    spanQuantidade.text(novaQuantidade);

    let valorUnitario = parseFloat($("#" + id + " .valor-produto").text().replace('R$ ', ''));
    let totalProduto = valorUnitario * novaQuantidade;
    $("#" + id + " .total-produto").text('R$ ' + totalProduto.toFixed(2));

    atualizarResumoCompra();
}

function removerProduto(id) {
    $("#" + id).remove();

    atualizarResumoCompra();
}

function atualizarResumoCompra() {
    let subtotal = 0;
    $("tbody tr").each(function () {
        subtotal += parseFloat($(this).find(".total-produto").text().replace('R$ ', ''));
    });

    $(".info div:nth-child(1) span:nth-child(2)").text('R$ ' + subtotal.toFixed(2));

    let frete = 0;
    $(".info div:nth-child(2) span:nth-child(2)").text('R$ ' + frete.toFixed(2));

    let total = subtotal + frete;

    $(".box footer span:nth-child(2)").text('R$ ' + total.toFixed(2));
}

