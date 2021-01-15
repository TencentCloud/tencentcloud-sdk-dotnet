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

namespace TencentCloud.Apcas.V20201127.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LabelValue : AbstractModel
    {
        
        /// <summary>
        /// 标签覆盖率占比（在整个上传的ID列表中的覆盖率）
        /// </summary>
        [JsonProperty("Proportion")]
        public float? Proportion{ get; set; }

        /// <summary>
        /// 标签大盘覆盖率占比
        /// </summary>
        [JsonProperty("Market")]
        public float? Market{ get; set; }

        /// <summary>
        /// TGI指数，由Proportion除以Market得到
        /// </summary>
        [JsonProperty("Tgi")]
        public float? Tgi{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Proportion", this.Proportion);
            this.SetParamSimple(map, prefix + "Market", this.Market);
            this.SetParamSimple(map, prefix + "Tgi", this.Tgi);
        }
    }
}

