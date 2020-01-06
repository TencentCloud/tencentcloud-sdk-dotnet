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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCCUrlAllowResponse : AbstractModel
    {
        
        /// <summary>
        /// 该字段被RecordList字段替代了，请不要使用
        /// </summary>
        [JsonProperty("Data")]
        public KeyValue[] Data{ get; set; }

        /// <summary>
        /// 记录总数
        /// </summary>
        [JsonProperty("Total")]
        public ulong? Total{ get; set; }

        /// <summary>
        /// 返回黑/白名单的记录，
        /// "Key":"url"时，"Value":值表示URL;
        /// "Key":"domain"时， "Value":值表示域名;
        /// "Key":"type"时，"Value":值表示黑白名单类型(white为白名单，block为黑名单);
        /// "Key":"protocol"时，"Value":值表示CC的防护类型(HTTP防护或HTTPS域名防护);
        /// </summary>
        [JsonProperty("RecordList")]
        public KeyValueRecord[] RecordList{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Data.", this.Data);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamArrayObj(map, prefix + "RecordList.", this.RecordList);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

