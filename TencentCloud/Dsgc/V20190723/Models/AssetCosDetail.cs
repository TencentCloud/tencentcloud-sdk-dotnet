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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AssetCosDetail : AbstractModel
    {
        
        /// <summary>
        /// 桶的名
        /// </summary>
        [JsonProperty("Bucket")]
        public string Bucket{ get; set; }

        /// <summary>
        /// 数据源类型
        /// </summary>
        [JsonProperty("DataType")]
        public string DataType{ get; set; }

        /// <summary>
        /// 文件的个数
        /// </summary>
        [JsonProperty("FileNums")]
        public long? FileNums{ get; set; }

        /// <summary>
        /// 敏感的文件个数
        /// </summary>
        [JsonProperty("SensitiveFileNums")]
        public long? SensitiveFileNums{ get; set; }

        /// <summary>
        /// 敏感分布
        /// </summary>
        [JsonProperty("DistributionData")]
        public Note[] DistributionData{ get; set; }

        /// <summary>
        /// cos文件的敏感数据个数
        /// </summary>
        [JsonProperty("MatchedNum")]
        public long? MatchedNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Bucket", this.Bucket);
            this.SetParamSimple(map, prefix + "DataType", this.DataType);
            this.SetParamSimple(map, prefix + "FileNums", this.FileNums);
            this.SetParamSimple(map, prefix + "SensitiveFileNums", this.SensitiveFileNums);
            this.SetParamArrayObj(map, prefix + "DistributionData.", this.DistributionData);
            this.SetParamSimple(map, prefix + "MatchedNum", this.MatchedNum);
        }
    }
}

