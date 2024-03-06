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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CollectConfig : AbstractModel
    {
        
        /// <summary>
        /// 指定采集类型的采集配置名称信息。
        /// <li>当CollectInfo中Type为0：表示元数据配置，name为元数据名称。
        /// 目前支持"container_id"，"container_name"，"image_name"，"namespace"，"pod_uid"，"pod_name"，"pod_ip"。
        /// </li>
        /// <li>当CollectInfo中Type为1：指定pod label，name为指定pod label名称。</li>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
        }
    }
}

