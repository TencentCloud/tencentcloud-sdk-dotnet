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

    public class ModifyFwGroupSwitchRequest : AbstractModel
    {
        
        /// <summary>
        /// 打开或关闭开关
        /// 0：关闭开关
        /// 1：打开开关
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }

        /// <summary>
        /// 是否操作全部开关 0 不操作全部开关，1 操作全部开关
        /// </summary>
        [JsonProperty("AllSwitch")]
        public long? AllSwitch{ get; set; }

        /// <summary>
        /// 开关列表
        /// </summary>
        [JsonProperty("SwitchList")]
        public FwGroupSwitch[] SwitchList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "AllSwitch", this.AllSwitch);
            this.SetParamArrayObj(map, prefix + "SwitchList.", this.SwitchList);
        }
    }
}

