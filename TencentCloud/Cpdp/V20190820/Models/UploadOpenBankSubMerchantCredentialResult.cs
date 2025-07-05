/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

    public class UploadOpenBankSubMerchantCredentialResult : AbstractModel
    {
        
        /// <summary>
        /// 上传状态
        /// SUCCESS：上传成功
        /// FAILED：上传失败
        /// PROCESSING:上传中
        /// </summary>
        [JsonProperty("UploadStatus")]
        public string UploadStatus{ get; set; }

        /// <summary>
        /// 上传描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UploadMessage")]
        public string UploadMessage{ get; set; }

        /// <summary>
        /// 渠道上传流水号
        /// </summary>
        [JsonProperty("ChannelApplyId")]
        public string ChannelApplyId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UploadStatus", this.UploadStatus);
            this.SetParamSimple(map, prefix + "UploadMessage", this.UploadMessage);
            this.SetParamSimple(map, prefix + "ChannelApplyId", this.ChannelApplyId);
        }
    }
}

