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

namespace TencentCloud.Iotcloud.V20180614.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProductProperties : AbstractModel
    {
        
        /// <summary>
        /// 产品描述
        /// </summary>
        [JsonProperty("ProductDescription")]
        public string ProductDescription{ get; set; }

        /// <summary>
        /// 加密类型，1表示证书认证，2表示签名认证。如不填写，默认值是1
        /// </summary>
        [JsonProperty("EncryptionType")]
        public string EncryptionType{ get; set; }

        /// <summary>
        /// 产品所属区域，目前只支持广州（gz）
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 产品类型，各个类型值代表的节点-类型如下：
        /// 0 普通产品，2 NB-IoT产品，4 LoRa产品，3 LoRa网关产品，5 普通网关产品   默认值是0
        /// </summary>
        [JsonProperty("ProductType")]
        public ulong? ProductType{ get; set; }

        /// <summary>
        /// 数据格式，取值为json或者custom，默认值是json
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// 产品所属平台，默认值是0
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// LoRa产品运营侧APPEUI，只有LoRa产品需要填写
        /// </summary>
        [JsonProperty("Appeui")]
        public string Appeui{ get; set; }

        /// <summary>
        /// 产品绑定的物模型ID，-1表示不绑定
        /// </summary>
        [JsonProperty("ModelId")]
        public string ModelId{ get; set; }

        /// <summary>
        /// 产品绑定的物模型名称
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// 产品密钥，suite产品才会有
        /// </summary>
        [JsonProperty("ProductKey")]
        public string ProductKey{ get; set; }

        /// <summary>
        /// 动态注册类型 0-关闭, 1-预定义设备名 2-动态定义设备名
        /// </summary>
        [JsonProperty("RegisterType")]
        public ulong? RegisterType{ get; set; }

        /// <summary>
        /// 动态注册产品秘钥
        /// </summary>
        [JsonProperty("ProductSecret")]
        public string ProductSecret{ get; set; }

        /// <summary>
        /// RegisterType为2时，设备动态创建的限制数量
        /// </summary>
        [JsonProperty("RegisterLimit")]
        public ulong? RegisterLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductDescription", this.ProductDescription);
            this.SetParamSimple(map, prefix + "EncryptionType", this.EncryptionType);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "ProductType", this.ProductType);
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "Appeui", this.Appeui);
            this.SetParamSimple(map, prefix + "ModelId", this.ModelId);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "ProductKey", this.ProductKey);
            this.SetParamSimple(map, prefix + "RegisterType", this.RegisterType);
            this.SetParamSimple(map, prefix + "ProductSecret", this.ProductSecret);
            this.SetParamSimple(map, prefix + "RegisterLimit", this.RegisterLimit);
        }
    }
}

