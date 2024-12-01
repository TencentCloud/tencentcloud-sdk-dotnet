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

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InternalMedicineAbdomenSpleen : AbstractModel
    {
        
        /// <summary>
        /// 脾脏总体描述
        /// </summary>
        [JsonProperty("Src")]
        public KeyValueItem Src{ get; set; }

        /// <summary>
        /// 脾脏大小
        /// </summary>
        [JsonProperty("Size")]
        public KeyValueItem Size{ get; set; }

        /// <summary>
        /// 脾脏触诊
        /// </summary>
        [JsonProperty("Palpation")]
        public KeyValueItem Palpation{ get; set; }

        /// <summary>
        /// 脾脏叩诊
        /// </summary>
        [JsonProperty("Percussion")]
        public KeyValueItem Percussion{ get; set; }

        /// <summary>
        /// 脾脏压痛
        /// </summary>
        [JsonProperty("Tenderness")]
        public KeyValueItem Tenderness{ get; set; }

        /// <summary>
        /// 脾脏质地
        /// </summary>
        [JsonProperty("Consistency")]
        public KeyValueItem Consistency{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Src.", this.Src);
            this.SetParamObj(map, prefix + "Size.", this.Size);
            this.SetParamObj(map, prefix + "Palpation.", this.Palpation);
            this.SetParamObj(map, prefix + "Percussion.", this.Percussion);
            this.SetParamObj(map, prefix + "Tenderness.", this.Tenderness);
            this.SetParamObj(map, prefix + "Consistency.", this.Consistency);
        }
    }
}

