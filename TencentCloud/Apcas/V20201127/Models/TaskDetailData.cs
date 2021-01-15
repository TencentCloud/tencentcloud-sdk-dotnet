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

    public class TaskDetailData : AbstractModel
    {
        
        /// <summary>
        /// 画像TAG ID
        /// </summary>
        [JsonProperty("TagId")]
        public ulong? TagId{ get; set; }

        /// <summary>
        /// 画像TAG描述（如“省份分布”）
        /// </summary>
        [JsonProperty("TagDesc")]
        public string TagDesc{ get; set; }

        /// <summary>
        /// 画像Label对象列表（一个TAG对于N个Label，例如“省份分布”TAG对应“广东省”、“浙江省”等多个Label）
        /// </summary>
        [JsonProperty("LabelDetailDataList")]
        public LabelDetailData[] LabelDetailDataList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TagId", this.TagId);
            this.SetParamSimple(map, prefix + "TagDesc", this.TagDesc);
            this.SetParamArrayObj(map, prefix + "LabelDetailDataList.", this.LabelDetailDataList);
        }
    }
}

