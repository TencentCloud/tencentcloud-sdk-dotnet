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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeletePullStreamConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 配置 ID。
        /// 1. 在添加拉流配置接口 [CreatePullStreamConfig](/document/api/267/30159) 调用返回值中获取配置 ID。
        /// 2. 可以从接口 [DescribePullStreamConfigs](/document/api/267/30158) 中查询已创建过的拉流配置列表。
        /// </summary>
        [JsonProperty("ConfigId")]
        public string ConfigId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConfigId", this.ConfigId);
        }
    }
}

