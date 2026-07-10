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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RemoveModelRewriteRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>模型路由实例 ID。</p>
        /// </summary>
        [JsonProperty("ModelRouterId")]
        public string ModelRouterId{ get; set; }

        /// <summary>
        /// <p>要删除的源模型名（重写规则的 key）。</p><p>长度 1-255 字符；支持特殊值 <code>default</code> 表示删除兜底规则。</p><p>当指定的 SourceModel 当前不存在重写规则时，请求幂等成功。</p>
        /// </summary>
        [JsonProperty("SourceModel")]
        public string SourceModel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelRouterId", this.ModelRouterId);
            this.SetParamSimple(map, prefix + "SourceModel", this.SourceModel);
        }
    }
}

