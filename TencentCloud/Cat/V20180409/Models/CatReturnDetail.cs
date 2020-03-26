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

namespace TencentCloud.Cat.V20180409.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CatReturnDetail : AbstractModel
    {
        
        /// <summary>
        /// 运营商名称
        /// </summary>
        [JsonProperty("IspName")]
        public string IspName{ get; set; }

        /// <summary>
        /// 省份全拼
        /// </summary>
        [JsonProperty("Province")]
        public string Province{ get; set; }

        /// <summary>
        /// 省份中文名称
        /// </summary>
        [JsonProperty("ProvinceName")]
        public string ProvinceName{ get; set; }

        /// <summary>
        /// Map键值
        /// </summary>
        [JsonProperty("MapKey")]
        public string MapKey{ get; set; }

        /// <summary>
        /// 拨测目标的IP
        /// </summary>
        [JsonProperty("ServerIp")]
        public string ServerIp{ get; set; }

        /// <summary>
        /// 拨测失败个数
        /// </summary>
        [JsonProperty("ResultCount")]
        public ulong? ResultCount{ get; set; }

        /// <summary>
        /// 拨测失败返回码
        /// </summary>
        [JsonProperty("ResultCode")]
        public ulong? ResultCode{ get; set; }

        /// <summary>
        /// 拨测失败原因描述
        /// </summary>
        [JsonProperty("ErrorReason")]
        public string ErrorReason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IspName", this.IspName);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamSimple(map, prefix + "ProvinceName", this.ProvinceName);
            this.SetParamSimple(map, prefix + "MapKey", this.MapKey);
            this.SetParamSimple(map, prefix + "ServerIp", this.ServerIp);
            this.SetParamSimple(map, prefix + "ResultCount", this.ResultCount);
            this.SetParamSimple(map, prefix + "ResultCode", this.ResultCode);
            this.SetParamSimple(map, prefix + "ErrorReason", this.ErrorReason);
        }
    }
}

