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

namespace TencentCloud.Iotcloud.V20180614.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Task : AbstractModel
    {
        
        /// <summary>
        /// 批量更新影子任务的描述细节，当 taskType 取值为 “UpdateShadow” 时，此字段必填。描述见下 BatchUpdateShadow
        /// </summary>
        [JsonProperty("UpdateShadowTask")]
        public BatchUpdateShadow UpdateShadowTask{ get; set; }

        /// <summary>
        /// 批量下发消息任务的描述细节，当 taskType 取值为 “PublishMessage” 时，此字段必填。描述见下 BatchPublishMessage
        /// </summary>
        [JsonProperty("PublishMessageTask")]
        public BatchPublishMessage PublishMessageTask{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "UpdateShadowTask.", this.UpdateShadowTask);
            this.SetParamObj(map, prefix + "PublishMessageTask.", this.PublishMessageTask);
        }
    }
}

