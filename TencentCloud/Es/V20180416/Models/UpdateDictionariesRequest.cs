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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateDictionariesRequest : AbstractModel
    {
        
        /// <summary>
        /// ES实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 安装时填IK分词主词典COS地址，删除时填词典名如test.dic
        /// </summary>
        [JsonProperty("IkMainDicts")]
        public string[] IkMainDicts{ get; set; }

        /// <summary>
        /// 安装时填IK分词停用词词典COS地址，删除时填词典名如test.dic
        /// </summary>
        [JsonProperty("IkStopwords")]
        public string[] IkStopwords{ get; set; }

        /// <summary>
        /// 安装时填同义词词典COS地址，删除时填词典名如test.dic
        /// </summary>
        [JsonProperty("Synonym")]
        public string[] Synonym{ get; set; }

        /// <summary>
        /// 安装时填QQ分词词典COS地址，删除时填词典名如test.dic
        /// </summary>
        [JsonProperty("QQDict")]
        public string[] QQDict{ get; set; }

        /// <summary>
        /// 0：安装；1：删除。默认值0
        /// </summary>
        [JsonProperty("UpdateType")]
        public long? UpdateType{ get; set; }

        /// <summary>
        /// 是否强制重启集群。默认值false
        /// </summary>
        [JsonProperty("ForceRestart")]
        public bool? ForceRestart{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArraySimple(map, prefix + "IkMainDicts.", this.IkMainDicts);
            this.SetParamArraySimple(map, prefix + "IkStopwords.", this.IkStopwords);
            this.SetParamArraySimple(map, prefix + "Synonym.", this.Synonym);
            this.SetParamArraySimple(map, prefix + "QQDict.", this.QQDict);
            this.SetParamSimple(map, prefix + "UpdateType", this.UpdateType);
            this.SetParamSimple(map, prefix + "ForceRestart", this.ForceRestart);
        }
    }
}

