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

namespace TencentCloud.Cms.V20190321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLibSamplesRequest : AbstractModel
    {
        
        /// <summary>
        /// 单页条数，最大为100条
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 条数偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 词库ID
        /// </summary>
        [JsonProperty("LibID")]
        public string LibID{ get; set; }

        /// <summary>
        /// 词内容过滤
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 违规类型列表过滤
        /// </summary>
        [JsonProperty("EvilTypeList")]
        public long?[] EvilTypeList{ get; set; }

        /// <summary>
        /// 样本词ID列表过滤
        /// </summary>
        [JsonProperty("SampleIDs")]
        public string[] SampleIDs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "LibID", this.LibID);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamArraySimple(map, prefix + "EvilTypeList.", this.EvilTypeList);
            this.SetParamArraySimple(map, prefix + "SampleIDs.", this.SampleIDs);
        }
    }
}

