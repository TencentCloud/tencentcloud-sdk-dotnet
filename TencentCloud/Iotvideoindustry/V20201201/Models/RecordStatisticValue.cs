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

namespace TencentCloud.Iotvideoindustry.V20201201.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecordStatisticValue : AbstractModel
    {
        
        /// <summary>
        /// 期望执行时间 秒
        /// </summary>
        [JsonProperty("ExpectTimeLen")]
        public long? ExpectTimeLen{ get; set; }

        /// <summary>
        /// 实际执行时间 秒
        /// </summary>
        [JsonProperty("RecordTimeLen")]
        public long? RecordTimeLen{ get; set; }

        /// <summary>
        /// 存储大小 G
        /// </summary>
        [JsonProperty("FileSize")]
        public float? FileSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExpectTimeLen", this.ExpectTimeLen);
            this.SetParamSimple(map, prefix + "RecordTimeLen", this.RecordTimeLen);
            this.SetParamSimple(map, prefix + "FileSize", this.FileSize);
        }
    }
}

