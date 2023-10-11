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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RollbackDataEngineImageRequest : AbstractModel
    {
        
        /// <summary>
        /// 引擎ID
        /// </summary>
        [JsonProperty("DataEngineId")]
        public string DataEngineId{ get; set; }

        /// <summary>
        /// 检查是否能回滚的接口返回的FromRecordId参数
        /// </summary>
        [JsonProperty("FromRecordId")]
        public string FromRecordId{ get; set; }

        /// <summary>
        /// 检查是否能回滚的接口返回的ToRecordId参数
        /// </summary>
        [JsonProperty("ToRecordId")]
        public string ToRecordId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DataEngineId", this.DataEngineId);
            this.SetParamSimple(map, prefix + "FromRecordId", this.FromRecordId);
            this.SetParamSimple(map, prefix + "ToRecordId", this.ToRecordId);
        }
    }
}

