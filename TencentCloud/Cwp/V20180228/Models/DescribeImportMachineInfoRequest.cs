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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeImportMachineInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// 服务器内网IP（默认）/ 服务器名称 / 服务器ID 数组 (最大 1000条)
        /// </summary>
        [JsonProperty("MachineList")]
        public string[] MachineList{ get; set; }

        /// <summary>
        /// 批量导入的数据类型：Ip、Name、Id 三选一
        /// </summary>
        [JsonProperty("ImportType")]
        public string ImportType{ get; set; }

        /// <summary>
        /// 该参数已作废.
        /// </summary>
        [JsonProperty("IsQueryProMachine")]
        public bool? IsQueryProMachine{ get; set; }

        /// <summary>
        /// 过滤条件。
        /// <li>Version - String  是否必填：否 - 当前防护版本（ PRO_VERSION：专业版 | BASIC_VERSION：基础版 | Flagship : 旗舰版 | ProtectedMachines: 专业版+旗舰版）</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MachineList.", this.MachineList);
            this.SetParamSimple(map, prefix + "ImportType", this.ImportType);
            this.SetParamSimple(map, prefix + "IsQueryProMachine", this.IsQueryProMachine);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

