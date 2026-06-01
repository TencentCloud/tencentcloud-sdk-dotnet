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

namespace TencentCloud.Tcbr.V20220217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DiffConfigItem : AbstractModel
    {
        
        /// <summary>
        /// <p>配置项 Key<br>MinNum 最小副本数<br>MaxNum 最大副本数<br>PolicyDetails 扩缩容策略<br>AccessTypes 访问类型<br>TimerScale 定时扩缩容<br>InternalAccess 内网访问<br>OperationMode 运行模式 noScale | condScale | alwaysScale | custom ｜ manualScale<br>SessionAffinity 会话亲和性 open | close<br>CpuSpecs cpu 规格<br>MemSpecs mem规格<br>EnvParam 环境变量<br>LogPath 日志采集路径<br>Port 端口<br>Dockerfile dockerfile 文件名<br>BuildDir 目标目录<br>Tag 服务标签<br>LogType 日志类型 none | default | custom<br>LogSetId 日志集Id<br>LogTopicId 日志主题ID<br>LogParseType 日志解析类型 json ｜ line<br>EntryPoint entrypoint 命令<br>Cmd cmd命令<br>VpcConf 网络信息</p>
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// <p>字符串类型配置项值<br>InternalAccess、OperationMode、SessionAffinity、EnvParam、LogPath、Dockerfile、BuildDir、Tag、LogType、LogSetId、LogTopicId、LogParseType</p>
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }

        /// <summary>
        /// <p>int 类型配置项值<br>MinNum、MaxNum、Port</p>
        /// </summary>
        [JsonProperty("IntValue")]
        public long? IntValue{ get; set; }

        /// <summary>
        /// <p>bool 类型配置项值</p>
        /// </summary>
        [JsonProperty("BoolValue")]
        public bool? BoolValue{ get; set; }

        /// <summary>
        /// <p>浮点型配置项值<br>CpuSpecs、MemSpecs</p>
        /// </summary>
        [JsonProperty("FloatValue")]
        public float? FloatValue{ get; set; }

        /// <summary>
        /// <p>字符串数组配置项值<br>AccessTypes，EntryPoint，Cmd</p>
        /// </summary>
        [JsonProperty("ArrayValue")]
        public string[] ArrayValue{ get; set; }

        /// <summary>
        /// <p>扩缩容策略配置项值</p>
        /// </summary>
        [JsonProperty("PolicyDetails")]
        public HpaPolicy[] PolicyDetails{ get; set; }

        /// <summary>
        /// <p>定时扩缩容配置项值</p>
        /// </summary>
        [JsonProperty("TimerScale")]
        public TimerScale[] TimerScale{ get; set; }

        /// <summary>
        /// <p>配置内网访问时网络信息</p>
        /// </summary>
        [JsonProperty("VpcConf")]
        public VpcConf VpcConf{ get; set; }

        /// <summary>
        /// <p>存储配置信息</p>
        /// </summary>
        [JsonProperty("VolumesConf")]
        public VolumeConf[] VolumesConf{ get; set; }

        /// <summary>
        /// <p>公网访问配置</p>
        /// </summary>
        [JsonProperty("PublicNetConf")]
        public PublicNetConf PublicNetConf{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "IntValue", this.IntValue);
            this.SetParamSimple(map, prefix + "BoolValue", this.BoolValue);
            this.SetParamSimple(map, prefix + "FloatValue", this.FloatValue);
            this.SetParamArraySimple(map, prefix + "ArrayValue.", this.ArrayValue);
            this.SetParamArrayObj(map, prefix + "PolicyDetails.", this.PolicyDetails);
            this.SetParamArrayObj(map, prefix + "TimerScale.", this.TimerScale);
            this.SetParamObj(map, prefix + "VpcConf.", this.VpcConf);
            this.SetParamArrayObj(map, prefix + "VolumesConf.", this.VolumesConf);
            this.SetParamObj(map, prefix + "PublicNetConf.", this.PublicNetConf);
        }
    }
}

