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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetFunctionResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>函数最后修改时间</p>
        /// </summary>
        [JsonProperty("ModTime")]
        public string ModTime{ get; set; }

        /// <summary>
        /// <p>函数代码（&gt;1M 不返回）</p>
        /// </summary>
        [JsonProperty("CodeInfo")]
        public string CodeInfo{ get; set; }

        /// <summary>
        /// <p>函数描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>触发器列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Triggers")]
        public FunctionTrigger[] Triggers{ get; set; }

        /// <summary>
        /// <p>入口函数</p>
        /// </summary>
        [JsonProperty("Handler")]
        public string Handler{ get; set; }

        /// <summary>
        /// <p>代码大小（字节）</p>
        /// </summary>
        [JsonProperty("CodeSize")]
        public ulong? CodeSize{ get; set; }

        /// <summary>
        /// <p>超时时间（秒）</p>
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// <p>函数版本</p>
        /// </summary>
        [JsonProperty("FunctionVersion")]
        public string FunctionVersion{ get; set; }

        /// <summary>
        /// <p>内存大小（MB）</p>
        /// </summary>
        [JsonProperty("MemorySize")]
        public ulong? MemorySize{ get; set; }

        /// <summary>
        /// <p>运行环境</p>
        /// </summary>
        [JsonProperty("Runtime")]
        public string Runtime{ get; set; }

        /// <summary>
        /// <p>函数名称</p>
        /// </summary>
        [JsonProperty("FunctionName")]
        public string FunctionName{ get; set; }

        /// <summary>
        /// <p>VPC 配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VpcConfig")]
        public FunctionVpcConfig VpcConfig{ get; set; }

        /// <summary>
        /// <p>是否使用 GPU (&quot;TRUE&quot;/&quot;FALSE&quot;)</p>
        /// </summary>
        [JsonProperty("UseGpu")]
        public string UseGpu{ get; set; }

        /// <summary>
        /// <p>环境变量</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Environment")]
        public EnvironmentOut Environment{ get; set; }

        /// <summary>
        /// <p>代码校验结果 (&quot;success&quot;/&quot;failed&quot;)</p>
        /// </summary>
        [JsonProperty("CodeResult")]
        public string CodeResult{ get; set; }

        /// <summary>
        /// <p>代码错误码</p>
        /// </summary>
        [JsonProperty("ErrNo")]
        public long? ErrNo{ get; set; }

        /// <summary>
        /// <p>命名空间</p>
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// <p>角色</p>
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// <p>是否自动安装依赖 (&quot;TRUE&quot;/&quot;FALSE&quot;)</p>
        /// </summary>
        [JsonProperty("InstallDependency")]
        public string InstallDependency{ get; set; }

        /// <summary>
        /// <p>函数状态 (&quot;Active&quot;, &quot;Inactive&quot; 等)</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>CLS 日志集 ID</p>
        /// </summary>
        [JsonProperty("ClsLogsetId")]
        public string ClsLogsetId{ get; set; }

        /// <summary>
        /// <p>CLS Topic ID</p>
        /// </summary>
        [JsonProperty("ClsTopicId")]
        public string ClsTopicId{ get; set; }

        /// <summary>
        /// <p>函数 ID</p>
        /// </summary>
        [JsonProperty("FunctionId")]
        public string FunctionId{ get; set; }

        /// <summary>
        /// <p>标签列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>EIP 配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EipConfig")]
        public EipOutConfig EipConfig{ get; set; }

        /// <summary>
        /// <p>函数类型 (&quot;HTTP&quot; 或 &quot;Event&quot;)</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>是否启用 L5 (&quot;TRUE&quot;/&quot;FALSE&quot;)</p>
        /// </summary>
        [JsonProperty("L5Enable")]
        public string L5Enable{ get; set; }

        /// <summary>
        /// <p>函数创建时间</p>
        /// </summary>
        [JsonProperty("AddTime")]
        public string AddTime{ get; set; }

        /// <summary>
        /// <p>对应scf.GetFunction接口的OnsEnable，是否启用 Ons (&quot;TRUE&quot;/&quot;FALSE&quot;)</p>
        /// </summary>
        [JsonProperty("OnsEnable")]
        public string OnsEnable{ get; set; }

        /// <summary>
        /// <p>计费状态 (&quot;Available&quot; 等)</p>
        /// </summary>
        [JsonProperty("AvailableStatus")]
        public string AvailableStatus{ get; set; }

        /// <summary>
        /// <p>函数版本（查询时传入的）</p>
        /// </summary>
        [JsonProperty("Qualifier")]
        public string Qualifier{ get; set; }

        /// <summary>
        /// <p>初始化超时时间（秒）</p>
        /// </summary>
        [JsonProperty("InitTimeout")]
        public ulong? InitTimeout{ get; set; }

        /// <summary>
        /// <p>是否开启异步 (&quot;TRUE&quot;/&quot;FALSE&quot;)</p>
        /// </summary>
        [JsonProperty("AsyncRunEnable")]
        public string AsyncRunEnable{ get; set; }

        /// <summary>
        /// <p>是否开启事件追踪 (&quot;TRUE&quot;/&quot;FALSE&quot;)</p>
        /// </summary>
        [JsonProperty("TraceEnable")]
        public string TraceEnable{ get; set; }

        /// <summary>
        /// <p>镜像配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageConfig")]
        public AgentRuntimeCodeImageConfig ImageConfig{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModTime", this.ModTime);
            this.SetParamSimple(map, prefix + "CodeInfo", this.CodeInfo);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArrayObj(map, prefix + "Triggers.", this.Triggers);
            this.SetParamSimple(map, prefix + "Handler", this.Handler);
            this.SetParamSimple(map, prefix + "CodeSize", this.CodeSize);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "FunctionVersion", this.FunctionVersion);
            this.SetParamSimple(map, prefix + "MemorySize", this.MemorySize);
            this.SetParamSimple(map, prefix + "Runtime", this.Runtime);
            this.SetParamSimple(map, prefix + "FunctionName", this.FunctionName);
            this.SetParamObj(map, prefix + "VpcConfig.", this.VpcConfig);
            this.SetParamSimple(map, prefix + "UseGpu", this.UseGpu);
            this.SetParamObj(map, prefix + "Environment.", this.Environment);
            this.SetParamSimple(map, prefix + "CodeResult", this.CodeResult);
            this.SetParamSimple(map, prefix + "ErrNo", this.ErrNo);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "InstallDependency", this.InstallDependency);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ClsLogsetId", this.ClsLogsetId);
            this.SetParamSimple(map, prefix + "ClsTopicId", this.ClsTopicId);
            this.SetParamSimple(map, prefix + "FunctionId", this.FunctionId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "EipConfig.", this.EipConfig);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "L5Enable", this.L5Enable);
            this.SetParamSimple(map, prefix + "AddTime", this.AddTime);
            this.SetParamSimple(map, prefix + "OnsEnable", this.OnsEnable);
            this.SetParamSimple(map, prefix + "AvailableStatus", this.AvailableStatus);
            this.SetParamSimple(map, prefix + "Qualifier", this.Qualifier);
            this.SetParamSimple(map, prefix + "InitTimeout", this.InitTimeout);
            this.SetParamSimple(map, prefix + "AsyncRunEnable", this.AsyncRunEnable);
            this.SetParamSimple(map, prefix + "TraceEnable", this.TraceEnable);
            this.SetParamObj(map, prefix + "ImageConfig.", this.ImageConfig);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

