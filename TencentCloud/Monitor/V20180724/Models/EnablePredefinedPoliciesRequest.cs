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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EnablePredefinedPoliciesRequest : AbstractModel
    {
        
        /// <summary>
        /// 预设配置id
        /// </summary>
        [JsonProperty("PredefinedConfigID")]
        public string PredefinedConfigID{ get; set; }

        /// <summary>
        /// 云产品id
        /// </summary>
        [JsonProperty("PredefinedGroupID")]
        public string PredefinedGroupID{ get; set; }

        /// <summary>
        /// 通知模板id
        /// </summary>
        [JsonProperty("NoticeIDs")]
        public string[] NoticeIDs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PredefinedConfigID", this.PredefinedConfigID);
            this.SetParamSimple(map, prefix + "PredefinedGroupID", this.PredefinedGroupID);
            this.SetParamArraySimple(map, prefix + "NoticeIDs.", this.NoticeIDs);
        }
    }
}

