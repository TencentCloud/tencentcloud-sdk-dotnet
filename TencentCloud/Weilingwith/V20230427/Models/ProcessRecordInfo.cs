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

namespace TencentCloud.Weilingwith.V20230427.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProcessRecordInfo : AbstractModel
    {
        
        /// <summary>
        /// 告警的id
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 处理时间，毫秒
        /// </summary>
        [JsonProperty("ProcessTime")]
        public long? ProcessTime{ get; set; }

        /// <summary>
        /// 处理类型，此处操作类型固定填add_record
        /// </summary>
        [JsonProperty("ProcessType")]
        public string ProcessType{ get; set; }

        /// <summary>
        /// 注:此字段填写的是孪生中台的用户，非孪生中台用户不填该字段
        /// [{\"id\":\"123\",\"name\":\"tes\"}]
        /// </summary>
        [JsonProperty("Processor")]
        public string Processor{ get; set; }

        /// <summary>
        /// 处理描述信息
        /// </summary>
        [JsonProperty("ProcessDescription")]
        public string ProcessDescription{ get; set; }

        /// <summary>
        /// 附加文件标识
        /// </summary>
        [JsonProperty("AttachedFileId")]
        public string AttachedFileId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "ProcessTime", this.ProcessTime);
            this.SetParamSimple(map, prefix + "ProcessType", this.ProcessType);
            this.SetParamSimple(map, prefix + "Processor", this.Processor);
            this.SetParamSimple(map, prefix + "ProcessDescription", this.ProcessDescription);
            this.SetParamSimple(map, prefix + "AttachedFileId", this.AttachedFileId);
        }
    }
}

