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

namespace TencentCloud.Cms.V20190321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CodeDetail : AbstractModel
    {
        
        /// <summary>
        /// 二维码文本的编码格式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StrCharset")]
        public string StrCharset{ get; set; }

        /// <summary>
        /// 二维码在图片中的位置，由边界点的坐标表示
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QrCodePosition")]
        public CodePosition[] QrCodePosition{ get; set; }

        /// <summary>
        /// 二维码的文本内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StrQrCodeText")]
        public string StrQrCodeText{ get; set; }

        /// <summary>
        /// 二维码的类型：1:ONED_BARCODE，2:QRCOD，3:WXCODE，4:PDF417，5:DATAMATRIX
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Uint32QrCodeType")]
        public long? Uint32QrCodeType{ get; set; }

        /// <summary>
        /// 二维码文本的编码格式（已废弃）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CodeCharset")]
        public string CodeCharset{ get; set; }

        /// <summary>
        /// 二维码在图片中的位置，由边界点的坐标表示（已废弃）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CodePosition")]
        public CodePosition[] CodePosition{ get; set; }

        /// <summary>
        /// 二维码的文本内容（已废弃）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CodeText")]
        public string CodeText{ get; set; }

        /// <summary>
        /// 二维码的类型：1:ONED_BARCODE，2:QRCOD，3:WXCODE，4:PDF417，5:DATAMATRIX（已废弃）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CodeType")]
        public long? CodeType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StrCharset", this.StrCharset);
            this.SetParamArrayObj(map, prefix + "QrCodePosition.", this.QrCodePosition);
            this.SetParamSimple(map, prefix + "StrQrCodeText", this.StrQrCodeText);
            this.SetParamSimple(map, prefix + "Uint32QrCodeType", this.Uint32QrCodeType);
            this.SetParamSimple(map, prefix + "CodeCharset", this.CodeCharset);
            this.SetParamArrayObj(map, prefix + "CodePosition.", this.CodePosition);
            this.SetParamSimple(map, prefix + "CodeText", this.CodeText);
            this.SetParamSimple(map, prefix + "CodeType", this.CodeType);
        }
    }
}

