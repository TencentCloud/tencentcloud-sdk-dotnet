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

namespace TencentCloud.Ses.V20201002.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateReceiverDetailWithDataRequest : AbstractModel
    {
        
        /// <summary>
        /// 收件人列表ID
        /// </summary>
        [JsonProperty("ReceiverId")]
        public ulong? ReceiverId{ get; set; }

        /// <summary>
        /// 收信人邮箱以及模板参数，数组形式。收件人个数限制20000个以内。
        /// </summary>
        [JsonProperty("Datas")]
        public ReceiverInputData[] Datas{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReceiverId", this.ReceiverId);
            this.SetParamArrayObj(map, prefix + "Datas.", this.Datas);
        }
    }
}

