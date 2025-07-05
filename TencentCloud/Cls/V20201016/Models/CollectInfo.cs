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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CollectInfo : AbstractModel
    {
        
        /// <summary>
        /// 采集类型，必填字段。
        /// <li>0：元数据配置。</li>
        /// <li>1：指定Pod Label。</li>
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 指定采集类型的采集配置信息。
        /// <li>当Type为0时，CollectConfigs不允许为空。</li>
        /// <li>当Type为1时，CollectConfigs为空时，表示选择所有Pod Label；否则CollectConfigs为指定Pod Label。</li>
        /// </summary>
        [JsonProperty("CollectConfigs")]
        public CollectConfig[] CollectConfigs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "CollectConfigs.", this.CollectConfigs);
        }
    }
}

