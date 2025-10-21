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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConsistencyOption : AbstractModel
    {
        
        /// <summary>
        /// 一致性检测类型: full(全量检测迁移对象)、noCheck(不检测)、notConfigured(未配置)
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// 校验对象选择。枚举值：sameAsMigrate-与迁移同步任务相同、custom-用户自定义，搭配Objects操作
        /// </summary>
        [JsonProperty("ObjectMode")]
        public string ObjectMode{ get; set; }

        /// <summary>
        /// 校验对象
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Objects")]
        public DatabaseTableObject Objects{ get; set; }

        /// <summary>
        /// 校验配置
        /// </summary>
        [JsonProperty("Options")]
        public CompareOptions Options{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "ObjectMode", this.ObjectMode);
            this.SetParamObj(map, prefix + "Objects.", this.Objects);
            this.SetParamObj(map, prefix + "Options.", this.Options);
        }
    }
}

