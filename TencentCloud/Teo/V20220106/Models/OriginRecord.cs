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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OriginRecord : AbstractModel
    {
        
        /// <summary>
        /// 记录值
        /// </summary>
        [JsonProperty("Record")]
        public string Record{ get; set; }

        /// <summary>
        /// 当源站配置类型Type=area时，表示区域
        /// 为空表示默认区域
        /// </summary>
        [JsonProperty("Area")]
        public string[] Area{ get; set; }

        /// <summary>
        /// 当源站配置类型Type=weight时，表示权重
        /// 取值范围为[1-100]
        /// 源站组内多个源站权重总和应为100
        /// </summary>
        [JsonProperty("Weight")]
        public ulong? Weight{ get; set; }

        /// <summary>
        /// 端口
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// 记录ID
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// 是否私有鉴权
        /// 当源站类型OriginType=third_part时有效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Private")]
        public bool? Private{ get; set; }

        /// <summary>
        /// 私有鉴权参数
        /// 当源站类型Private=true时有效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PrivateParameter")]
        public OriginRecordPrivateParameter[] PrivateParameter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Record", this.Record);
            this.SetParamArraySimple(map, prefix + "Area.", this.Area);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "Private", this.Private);
            this.SetParamArrayObj(map, prefix + "PrivateParameter.", this.PrivateParameter);
        }
    }
}

