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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PortRiskAdvanceCFGParamItem : AbstractModel
    {
        
        /// <summary>
        /// 端口集合,以逗号分隔
        /// </summary>
        [JsonProperty("PortSets")]
        public string PortSets{ get; set; }

        /// <summary>
        /// 检测项类型，0-系统定义，1-用户自定义
        /// </summary>
        [JsonProperty("CheckType")]
        public long? CheckType{ get; set; }

        /// <summary>
        /// 检测项描述
        /// </summary>
        [JsonProperty("Detail")]
        public string Detail{ get; set; }

        /// <summary>
        /// 是否启用，1-启用，0-禁用
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PortSets", this.PortSets);
            this.SetParamSimple(map, prefix + "CheckType", this.CheckType);
            this.SetParamSimple(map, prefix + "Detail", this.Detail);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
        }
    }
}

