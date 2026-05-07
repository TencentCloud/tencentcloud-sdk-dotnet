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

    public class AIModelGroup : AbstractModel
    {
        
        /// <summary>
        /// <p>模型分组</p><p>枚举值：</p><ul><li>hunyuan-exp： 内置 hunyuan 分组，Models 中包含混元生文模型</li><li>hunyuan-image： 内置 hunyuan 分组，Models 中包含混元生图模型</li><li>deepseek： 内置 deepseek 分组，Models 中包含Deepseek生文模型</li><li>cloudbase： 内置 cloudbase 分组，Models 中包含云开发提供的模型，支持的所有模型可从 DescribeManagedAIModelList 获取</li><li>custom-xxxx： 自定义模型分组，Models 中包含用户自行配置的模型</li></ul>
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// <p>模型列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Models")]
        public AIModel[] Models{ get; set; }

        /// <summary>
        /// <p>模型类型</p><p>枚举值：</p><ul><li>builtin： 内置模型分组类别</li><li>custom： 用户自定义模型分组类别</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>原始模型类型</p><p>枚举值：</p><ul><li>builtin： 内置模型类型</li><li>custom： 用户自定义模型类型</li></ul>
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }

        /// <summary>
        /// <p>备注</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>模型地址</p>
        /// </summary>
        [JsonProperty("BaseUrl")]
        public string BaseUrl{ get; set; }

        /// <summary>
        /// <p>模型状态, 1: 开启, 2: 关闭</p>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// <p>模型密钥</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Secret")]
        public AIModelSecret Secret{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>更新时间</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamArrayObj(map, prefix + "Models.", this.Models);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "OriginType", this.OriginType);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "BaseUrl", this.BaseUrl);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "Secret.", this.Secret);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

