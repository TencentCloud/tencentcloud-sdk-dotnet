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

    public class ObjectType : AbstractModel
    {
        
        /// <summary>
        /// 对象类型ID
        /// </summary>
        [JsonProperty("ObjectTypeId")]
        public long? ObjectTypeId{ get; set; }

        /// <summary>
        /// 对象类型名称
        /// </summary>
        [JsonProperty("ObjectTypeTitle")]
        public string ObjectTypeTitle{ get; set; }

        /// <summary>
        /// 对象类型第一级
        /// </summary>
        [JsonProperty("ObjectTypeLevelOne")]
        public string ObjectTypeLevelOne{ get; set; }

        /// <summary>
        /// 对象类型参数
        /// </summary>
        [JsonProperty("ObjectTypeParams")]
        public ObjectTypeConfig ObjectTypeParams{ get; set; }

        /// <summary>
        /// tke接口json解析规则，null不需要解析
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ObjectTypeJsonParse")]
        public ObjectTypeJsonParse ObjectTypeJsonParse{ get; set; }

        /// <summary>
        /// 是否包含新动作
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ObjectHasNewAction")]
        public bool? ObjectHasNewAction{ get; set; }

        /// <summary>
        /// 对应在平台架构图中的资源类型名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ObjectPlatformName")]
        public string ObjectPlatformName{ get; set; }

        /// <summary>
        /// 1：平台支持的对象 2：应用支持的部分对象
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ObjectSupportType")]
        public long? ObjectSupportType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ObjectTypeId", this.ObjectTypeId);
            this.SetParamSimple(map, prefix + "ObjectTypeTitle", this.ObjectTypeTitle);
            this.SetParamSimple(map, prefix + "ObjectTypeLevelOne", this.ObjectTypeLevelOne);
            this.SetParamObj(map, prefix + "ObjectTypeParams.", this.ObjectTypeParams);
            this.SetParamObj(map, prefix + "ObjectTypeJsonParse.", this.ObjectTypeJsonParse);
            this.SetParamSimple(map, prefix + "ObjectHasNewAction", this.ObjectHasNewAction);
            this.SetParamSimple(map, prefix + "ObjectPlatformName", this.ObjectPlatformName);
            this.SetParamSimple(map, prefix + "ObjectSupportType", this.ObjectSupportType);
        }
    }
}

