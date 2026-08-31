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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ViewImage : AbstractModel
    {
        
        /// <summary>
        /// <p>视角类型</p><p>枚举值：</p><ul><li>front： 正视图 （必填）</li><li>back： 背视图</li><li>left： 左视图</li><li>right： 右视图</li><li>top： 顶视图</li><li>bottom： 底视图</li><li>left_front： 左前 45°</li><li>right_front： 右前 45°</li></ul><p>MultiViewImages 数组长度 ≥ 2 ; 必须包含 front 视角;  同一 ViewType 不允许重复; 每项必须提供 ViewImageUrl</p>
        /// </summary>
        [JsonProperty("ViewType")]
        public string ViewType{ get; set; }

        /// <summary>
        /// <p>图片 URL（http / https）</p>
        /// </summary>
        [JsonProperty("ViewImageUrl")]
        public string ViewImageUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ViewType", this.ViewType);
            this.SetParamSimple(map, prefix + "ViewImageUrl", this.ViewImageUrl);
        }
    }
}

