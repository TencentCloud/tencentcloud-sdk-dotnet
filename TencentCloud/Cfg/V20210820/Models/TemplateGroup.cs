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

namespace TencentCloud.Cfg.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TemplateGroup : AbstractModel
    {
        
        /// <summary>
        /// 经验库动作ID
        /// </summary>
        [JsonProperty("TemplateGroupId")]
        public long? TemplateGroupId{ get; set; }

        /// <summary>
        /// 经验库动作分组动作列表
        /// </summary>
        [JsonProperty("TemplateGroupActions")]
        public TemplateGroupAction[] TemplateGroupActions{ get; set; }

        /// <summary>
        /// 分组标题
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// 分组描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 分组顺序
        /// </summary>
        [JsonProperty("Order")]
        public long? Order{ get; set; }

        /// <summary>
        /// 执行模式。1 --- 顺序执行，2 --- 阶段执行
        /// </summary>
        [JsonProperty("Mode")]
        public long? Mode{ get; set; }

        /// <summary>
        /// 对象类型ID
        /// </summary>
        [JsonProperty("ObjectTypeId")]
        public long? ObjectTypeId{ get; set; }

        /// <summary>
        /// 分组创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 分组更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateGroupId", this.TemplateGroupId);
            this.SetParamArrayObj(map, prefix + "TemplateGroupActions.", this.TemplateGroupActions);
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "ObjectTypeId", this.ObjectTypeId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

