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

namespace TencentCloud.Mna.V20210119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateNetInfo : AbstractModel
    {
        
        /// <summary>
        /// 网络类型：
        /// 0:数据
        /// 1:Wi-Fi
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 启用/禁用
        /// </summary>
        [JsonProperty("DataEnable")]
        public bool? DataEnable{ get; set; }

        /// <summary>
        /// 上行限速：bit
        /// </summary>
        [JsonProperty("UploadLimit")]
        public ulong? UploadLimit{ get; set; }

        /// <summary>
        /// 下行限速：bit
        /// </summary>
        [JsonProperty("DownloadLimit")]
        public ulong? DownloadLimit{ get; set; }

        /// <summary>
        /// 网卡名
        /// </summary>
        [JsonProperty("NetInfoName")]
        public string NetInfoName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "DataEnable", this.DataEnable);
            this.SetParamSimple(map, prefix + "UploadLimit", this.UploadLimit);
            this.SetParamSimple(map, prefix + "DownloadLimit", this.DownloadLimit);
            this.SetParamSimple(map, prefix + "NetInfoName", this.NetInfoName);
        }
    }
}

