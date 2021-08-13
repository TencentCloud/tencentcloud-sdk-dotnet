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

    public class NewModeItems : AbstractModel
    {
        
        /// <summary>
        /// 新增模式下接入的vpc列表
        /// </summary>
        [JsonProperty("VpcList")]
        public string[] VpcList{ get; set; }

        /// <summary>
        /// 新增模式下绑定的出口弹性公网ip列表，其中Eips和AddCount至少传递一个。
        /// </summary>
        [JsonProperty("Eips")]
        public string[] Eips{ get; set; }

        /// <summary>
        /// 新增模式下新增绑定的出口弹性公网ip个数，其中Eips和AddCount至少传递一个。
        /// </summary>
        [JsonProperty("AddCount")]
        public long? AddCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "VpcList.", this.VpcList);
            this.SetParamArraySimple(map, prefix + "Eips.", this.Eips);
            this.SetParamSimple(map, prefix + "AddCount", this.AddCount);
        }
    }
}

