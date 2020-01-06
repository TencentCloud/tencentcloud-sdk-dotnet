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

namespace TencentCloud.Iot.V20180123.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddProductRequest : AbstractModel
    {
        
        /// <summary>
        /// 产品名称，同一区域产品名称需唯一，支持中文、英文字母、中划线和下划线，长度不超过31个字符，中文占两个字符
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 产品描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 数据模版
        /// </summary>
        [JsonProperty("DataTemplate")]
        public DataTemplate[] DataTemplate{ get; set; }

        /// <summary>
        /// 产品版本（native表示基础版，template表示高级版，默认值为template）
        /// </summary>
        [JsonProperty("DataProtocol")]
        public string DataProtocol{ get; set; }

        /// <summary>
        /// 设备认证方式（1：动态令牌，2：签名直连鉴权）
        /// </summary>
        [JsonProperty("AuthType")]
        public ulong? AuthType{ get; set; }

        /// <summary>
        /// 通信方式（other/wifi/cellular/nb-iot）
        /// </summary>
        [JsonProperty("CommProtocol")]
        public string CommProtocol{ get; set; }

        /// <summary>
        /// 产品的设备类型（device: 直连设备；sub_device：子设备；gateway：网关设备）
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArrayObj(map, prefix + "DataTemplate.", this.DataTemplate);
            this.SetParamSimple(map, prefix + "DataProtocol", this.DataProtocol);
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamSimple(map, prefix + "CommProtocol", this.CommProtocol);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
        }
    }
}

