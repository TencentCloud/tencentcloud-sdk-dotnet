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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Function : AbstractModel
    {
        
        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("ModTime")]
        public string ModTime{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("AddTime")]
        public string AddTime{ get; set; }

        /// <summary>
        /// 运行时
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Runtime")]
        public string Runtime{ get; set; }

        /// <summary>
        /// 函数名称
        /// </summary>
        [JsonProperty("FunctionName")]
        public string FunctionName{ get; set; }

        /// <summary>
        /// 函数ID
        /// </summary>
        [JsonProperty("FunctionId")]
        public string FunctionId{ get; set; }

        /// <summary>
        /// 命名空间
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 函数状态，状态值及流转[参考此处](https://cloud.tencent.com/document/product/583/47175)
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 函数状态详情
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// 函数描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 函数标签
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 函数类型，取值为 HTTP 或者 Event
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 函数状态失败原因
        /// </summary>
        [JsonProperty("StatusReasons")]
        public StatusReason[] StatusReasons{ get; set; }

        /// <summary>
        /// 函数所有版本预置并发内存总和
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalProvisionedConcurrencyMem")]
        public ulong? TotalProvisionedConcurrencyMem{ get; set; }

        /// <summary>
        /// 函数并发保留内存
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReservedConcurrencyMem")]
        public ulong? ReservedConcurrencyMem{ get; set; }

        /// <summary>
        /// 函数异步属性，取值 TRUE 或者 FALSE
        /// </summary>
        [JsonProperty("AsyncRunEnable")]
        public string AsyncRunEnable{ get; set; }

        /// <summary>
        /// 异步函数是否开启调用追踪，取值 TRUE 或者 FALSE
        /// </summary>
        [JsonProperty("TraceEnable")]
        public string TraceEnable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModTime", this.ModTime);
            this.SetParamSimple(map, prefix + "AddTime", this.AddTime);
            this.SetParamSimple(map, prefix + "Runtime", this.Runtime);
            this.SetParamSimple(map, prefix + "FunctionName", this.FunctionName);
            this.SetParamSimple(map, prefix + "FunctionId", this.FunctionId);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "StatusReasons.", this.StatusReasons);
            this.SetParamSimple(map, prefix + "TotalProvisionedConcurrencyMem", this.TotalProvisionedConcurrencyMem);
            this.SetParamSimple(map, prefix + "ReservedConcurrencyMem", this.ReservedConcurrencyMem);
            this.SetParamSimple(map, prefix + "AsyncRunEnable", this.AsyncRunEnable);
            this.SetParamSimple(map, prefix + "TraceEnable", this.TraceEnable);
        }
    }
}

