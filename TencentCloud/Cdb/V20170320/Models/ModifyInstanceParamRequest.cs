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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyInstanceParamRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID 列表。可通过 [DescribeDBInstances](https://cloud.tencent.com/document/product/236/15872) 接口获取。
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 要修改的参数列表。每一个元素是 Name 和 CurrentValue 的组合。Name 是参数名，CurrentValue 是要修改成的值。
        /// </summary>
        [JsonProperty("ParamList")]
        public Parameter[] ParamList{ get; set; }

        /// <summary>
        /// 模板 ID，ParamList 和 TemplateId 必须至少传其中之一。可通过 [DescribeParamTemplates](https://cloud.tencent.com/document/api/236/32659) 接口获取。
        /// </summary>
        [JsonProperty("TemplateId")]
        public long? TemplateId{ get; set; }

        /// <summary>
        /// 执行参数调整任务的方式，默认为 0。支持值包括：0 - 立刻执行，1 - 时间窗执行；当该值为 1 时，每次只能传一个实例（InstanceIds数量为1）
        /// </summary>
        [JsonProperty("WaitSwitch")]
        public long? WaitSwitch{ get; set; }

        /// <summary>
        /// 参数是否同步到主实例下的只读实例。true 为不同步，false 为同步。默认为 false。
        /// </summary>
        [JsonProperty("NotSyncRo")]
        public bool? NotSyncRo{ get; set; }

        /// <summary>
        /// 参数是否同步到主实例下的灾备实例。true 为不同步，false 为同步。默认为 false。
        /// </summary>
        [JsonProperty("NotSyncDr")]
        public bool? NotSyncDr{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamArrayObj(map, prefix + "ParamList.", this.ParamList);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "WaitSwitch", this.WaitSwitch);
            this.SetParamSimple(map, prefix + "NotSyncRo", this.NotSyncRo);
            this.SetParamSimple(map, prefix + "NotSyncDr", this.NotSyncDr);
        }
    }
}

