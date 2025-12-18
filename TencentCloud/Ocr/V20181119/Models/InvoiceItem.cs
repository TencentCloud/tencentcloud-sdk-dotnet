/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InvoiceItem : AbstractModel
    {
        
        /// <summary>
        /// 识别结果。
        /// OK：表示识别成功；FailedOperation.UnsupportedInvoice：表示不支持识别；
        /// FailedOperation.UnKnowError：表示识别失败；
        /// 其它错误码见各个票据接口的定义。
        /// </summary>
        [JsonProperty("Code")]
        public string Code{ get; set; }

        /// <summary>
        /// 识别出的图片所属的票据类型。
        /// -1：未知类型
        /// 0：出租车发票
        /// 1：定额发票
        /// 2：火车票
        /// 3：增值税发票
        /// 5：机票行程单
        /// 8：通用机打发票
        /// 9：汽车票
        /// 10：轮船票
        /// 11：增值税发票（卷票）
        /// 12：购车发票
        /// 13：过路过桥费发票
        /// 15：非税发票
        /// 16：全电发票
        /// 17：医疗发票
        /// 18：完税凭证
        /// 19：海关缴款书
        /// 20：银行回单
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 该发票在原图片中的四点坐标。
        /// </summary>
        [JsonProperty("Polygon")]
        public Polygon Polygon{ get; set; }

        /// <summary>
        /// 识别出切图后各图片的旋转角度。
        /// </summary>
        [JsonProperty("Angle")]
        public float? Angle{ get; set; }

        /// <summary>
        /// 识别到的内容。
        /// </summary>
        [JsonProperty("SingleInvoiceInfos")]
        public SingleInvoiceItem SingleInvoiceInfos{ get; set; }

        /// <summary>
        /// 发票处于识别图片或PDF文件中的页码，默认从1开始。
        /// </summary>
        [JsonProperty("Page")]
        public long? Page{ get; set; }

        /// <summary>
        /// 发票详细类型，详见票据识别（高级版）接口文档说明中 SubType 返回值说明
        /// </summary>
        [JsonProperty("SubType")]
        public string SubType{ get; set; }

        /// <summary>
        /// 发票类型描述，详见票据识别（高级版）接口文档说明中 TypeDescription  返回值说明
        /// </summary>
        [JsonProperty("TypeDescription")]
        public string TypeDescription{ get; set; }

        /// <summary>
        /// 切割单图文件，Base64编码后的切图后的图片文件，开启 EnableCutImage 后进行返回
        /// </summary>
        [JsonProperty("CutImage")]
        public string CutImage{ get; set; }

        /// <summary>
        /// 发票详细类型描述，详见上方 SubType 返回值说明
        /// </summary>
        [JsonProperty("SubTypeDescription")]
        public string SubTypeDescription{ get; set; }

        /// <summary>
        /// 该发票中所有字段坐标信息。包括字段英文名称、字段值所在位置四点坐标、字段所属行号，具体内容请点击左侧链接。
        /// 字段在原始图的坐标可以根据Polygon转换得出。
        /// </summary>
        [JsonProperty("ItemPolygon")]
        public ItemPolygonInfo[] ItemPolygon{ get; set; }

        /// <summary>
        /// 二维码数据。
        /// </summary>
        [JsonProperty("QRCode")]
        public string QRCode{ get; set; }

        /// <summary>
        /// 印章信息
        /// </summary>
        [JsonProperty("InvoiceSealInfo")]
        public InvoiceSealInfo InvoiceSealInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "Polygon.", this.Polygon);
            this.SetParamSimple(map, prefix + "Angle", this.Angle);
            this.SetParamObj(map, prefix + "SingleInvoiceInfos.", this.SingleInvoiceInfos);
            this.SetParamSimple(map, prefix + "Page", this.Page);
            this.SetParamSimple(map, prefix + "SubType", this.SubType);
            this.SetParamSimple(map, prefix + "TypeDescription", this.TypeDescription);
            this.SetParamSimple(map, prefix + "CutImage", this.CutImage);
            this.SetParamSimple(map, prefix + "SubTypeDescription", this.SubTypeDescription);
            this.SetParamArrayObj(map, prefix + "ItemPolygon.", this.ItemPolygon);
            this.SetParamSimple(map, prefix + "QRCode", this.QRCode);
            this.SetParamObj(map, prefix + "InvoiceSealInfo.", this.InvoiceSealInfo);
        }
    }
}

