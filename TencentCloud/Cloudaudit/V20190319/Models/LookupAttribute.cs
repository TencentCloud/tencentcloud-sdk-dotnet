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

namespace TencentCloud.Cloudaudit.V20190319.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LookupAttribute : AbstractModel
    {
        
        /// <summary>
        /// AttributeKey的有效取值范围是:RequestId、EventName、ActionType、PrincipalId、ResourceId、ResourceName、AccessKeyId、SensitiveAction、ApiErrorCode、CamErrorCode、SourceIPAddress、Tags
        /// </summary>
        [JsonProperty("AttributeKey")]
        public string AttributeKey{ get; set; }

        /// <summary>
        /// AttributeValue的值
        /// </summary>
        [JsonProperty("AttributeValue")]
        public string AttributeValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AttributeKey", this.AttributeKey);
            this.SetParamSimple(map, prefix + "AttributeValue", this.AttributeValue);
        }
    }
}

