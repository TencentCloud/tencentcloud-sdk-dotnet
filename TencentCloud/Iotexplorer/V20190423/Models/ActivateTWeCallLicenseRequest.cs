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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ActivateTWeCallLicenseRequest : AbstractModel
    {
        
        /// <summary>
        /// TWecall类型： 0-测试激活码； 1-家庭安防场景； 2-穿戴类场景； 3-生活娱乐场景； 4-对讲及其它场景
        /// </summary>
        [JsonProperty("PkgType")]
        public long? PkgType{ get; set; }

        /// <summary>
        /// appId
        /// </summary>
        [JsonProperty("MiniProgramAppId")]
        public string MiniProgramAppId{ get; set; }

        /// <summary>
        /// 设备列表
        /// </summary>
        [JsonProperty("DeviceList")]
        public TWeCallInfo[] DeviceList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PkgType", this.PkgType);
            this.SetParamSimple(map, prefix + "MiniProgramAppId", this.MiniProgramAppId);
            this.SetParamArrayObj(map, prefix + "DeviceList.", this.DeviceList);
        }
    }
}

