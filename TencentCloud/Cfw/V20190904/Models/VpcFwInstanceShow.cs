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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VpcFwInstanceShow : AbstractModel
    {
        
        /// <summary>
        /// VPC防火墙实例ID
        /// </summary>
        [JsonProperty("FwInsId")]
        public string FwInsId{ get; set; }

        /// <summary>
        /// VPC防火墙实例名称
        /// </summary>
        [JsonProperty("FwInsName")]
        public string FwInsName{ get; set; }

        /// <summary>
        /// 网络经过VPC防火墙CVM所在地域
        /// </summary>
        [JsonProperty("FwInsRegion")]
        public string FwInsRegion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FwInsId", this.FwInsId);
            this.SetParamSimple(map, prefix + "FwInsName", this.FwInsName);
            this.SetParamSimple(map, prefix + "FwInsRegion", this.FwInsRegion);
        }
    }
}

