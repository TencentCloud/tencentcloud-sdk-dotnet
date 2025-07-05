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

namespace TencentCloud.Iotvideo.V20211125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateProductRequest : AbstractModel
    {
        
        /// <summary>
        /// 产品名称
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// 产品设备类型 1.普通设备 2.NVR设备
        /// </summary>
        [JsonProperty("DeviceType")]
        public ulong? DeviceType{ get; set; }

        /// <summary>
        /// 产品有效期
        /// </summary>
        [JsonProperty("ProductVaildYears")]
        public ulong? ProductVaildYears{ get; set; }

        /// <summary>
        /// 设备功能码 ypsxth音频双向通话 spdxth视频单向通话 sxysp双向音视频
        /// 注意：此字段只支持创建'摄像头'和'儿童手表'，摄像头传["ypsxth","spdxth"]，儿童手表传["ypsxth","spdxth","sxysp"]，创建其它品类的产品需要传递CategoryId字段，通过云api调用此接口时，如果传了CategoryId字段，将忽略Features字段,但Features仍需传值(可传任意字符串数组)
        /// </summary>
        [JsonProperty("Features")]
        public string[] Features{ get; set; }

        /// <summary>
        /// 芯片厂商id，通用设备填default
        /// </summary>
        [JsonProperty("ChipManufactureId")]
        public string ChipManufactureId{ get; set; }

        /// <summary>
        /// 芯片id，通用设备填default
        /// </summary>
        [JsonProperty("ChipId")]
        public string ChipId{ get; set; }

        /// <summary>
        /// 产品描述信息
        /// </summary>
        [JsonProperty("ProductDescription")]
        public string ProductDescription{ get; set; }

        /// <summary>
        /// 设备操作系统，通用设备填default
        /// </summary>
        [JsonProperty("ChipOs")]
        public string ChipOs{ get; set; }

        /// <summary>
        /// 认证方式 只支持取值为2 psk认证
        /// </summary>
        [JsonProperty("EncryptionType")]
        public ulong? EncryptionType{ get; set; }

        /// <summary>
        /// 产品品类id,113:摄像头,567:儿童手表,595:可视对讲门锁
        /// 注意：通过云api调用此接口时，如果传了CategoryId字段，将忽略Features字段,但Features仍需传值(可传任意字符串数组)
        /// </summary>
        [JsonProperty("CategoryId")]
        public ulong? CategoryId{ get; set; }

        /// <summary>
        /// 连接类型，wifi表示WIFI连接，cellular表示4G连接
        /// </summary>
        [JsonProperty("NetType")]
        public string NetType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "ProductVaildYears", this.ProductVaildYears);
            this.SetParamArraySimple(map, prefix + "Features.", this.Features);
            this.SetParamSimple(map, prefix + "ChipManufactureId", this.ChipManufactureId);
            this.SetParamSimple(map, prefix + "ChipId", this.ChipId);
            this.SetParamSimple(map, prefix + "ProductDescription", this.ProductDescription);
            this.SetParamSimple(map, prefix + "ChipOs", this.ChipOs);
            this.SetParamSimple(map, prefix + "EncryptionType", this.EncryptionType);
            this.SetParamSimple(map, prefix + "CategoryId", this.CategoryId);
            this.SetParamSimple(map, prefix + "NetType", this.NetType);
        }
    }
}

