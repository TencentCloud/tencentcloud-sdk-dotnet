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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApplyReconciliationFileResult : AbstractModel
    {
        
        /// <summary>
        /// 申请对账文件的任务ID。
        /// </summary>
        [JsonProperty("ApplyFileId")]
        public string ApplyFileId{ get; set; }

        /// <summary>
        /// 对账文件申请状态。
        /// __I__：申请中
        /// __S__：申请成功
        /// __F__：申请失败
        /// </summary>
        [JsonProperty("ApplyStatus")]
        public string ApplyStatus{ get; set; }

        /// <summary>
        /// 申请结果描述。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApplyMessage")]
        public string ApplyMessage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplyFileId", this.ApplyFileId);
            this.SetParamSimple(map, prefix + "ApplyStatus", this.ApplyStatus);
            this.SetParamSimple(map, prefix + "ApplyMessage", this.ApplyMessage);
        }
    }
}

