/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Iotvideo.V20191126.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateProductRequest : AbstractModel
    {
        
        /// <summary>
        /// 产器型号(APP产品,为APP包名)
        /// </summary>
        [JsonProperty("ProductModel")]
        public string ProductModel{ get; set; }

        /// <summary>
        /// 产品名称
        /// 仅支持中文、英文、数字、下划线，不超过32个字符
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// 产品描述信息
        /// 不支持单引号、双引号、退格符、回车符、换行符、制表符、反斜杠、下划线、“%”、“#”、“$”，不超过128字符
        /// </summary>
        [JsonProperty("ProductDescription")]
        public string ProductDescription{ get; set; }

        /// <summary>
        /// 设备功能码（ypsxth:音频双向通话 ，spdxth:视频单向通话）
        /// </summary>
        [JsonProperty("Features")]
        public string[] Features{ get; set; }

        /// <summary>
        /// 主芯片产商ID
        /// </summary>
        [JsonProperty("ChipManufactureId")]
        public string ChipManufactureId{ get; set; }

        /// <summary>
        /// 主芯片ID
        /// </summary>
        [JsonProperty("ChipId")]
        public string ChipId{ get; set; }

        /// <summary>
        /// 地域：
        /// China-Mainland（中国大陆）
        /// China-Hong Kong, Macao and Taiwan（港澳台地区）
        /// America（美国）
        /// Europe（欧洲）
        /// Other-Overseas（其他境外地区）
        /// </summary>
        [JsonProperty("ProductRegion")]
        public string ProductRegion{ get; set; }

        /// <summary>
        /// 设备类型, 0-普通视频设备，1-NVR设备
        /// </summary>
        [JsonProperty("ProductCate")]
        public ulong? ProductCate{ get; set; }

        /// <summary>
        /// 接入模型，bit0是0：公版小程序未接入，bit0是1：公版小程序已接入
        /// </summary>
        [JsonProperty("AccessMode")]
        public long? AccessMode{ get; set; }

        /// <summary>
        /// Linux,Android,Liteos等系统
        /// </summary>
        [JsonProperty("Os")]
        public string Os{ get; set; }

        /// <summary>
        /// 芯片架构，只是针对操作系统为android的
        /// </summary>
        [JsonProperty("ChipArch")]
        public string ChipArch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductModel", this.ProductModel);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "ProductDescription", this.ProductDescription);
            this.SetParamArraySimple(map, prefix + "Features.", this.Features);
            this.SetParamSimple(map, prefix + "ChipManufactureId", this.ChipManufactureId);
            this.SetParamSimple(map, prefix + "ChipId", this.ChipId);
            this.SetParamSimple(map, prefix + "ProductRegion", this.ProductRegion);
            this.SetParamSimple(map, prefix + "ProductCate", this.ProductCate);
            this.SetParamSimple(map, prefix + "AccessMode", this.AccessMode);
            this.SetParamSimple(map, prefix + "Os", this.Os);
            this.SetParamSimple(map, prefix + "ChipArch", this.ChipArch);
        }
    }
}

