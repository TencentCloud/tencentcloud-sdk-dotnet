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

namespace TencentCloud.Ms.V20180408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeUrlDetectionResultResponse : AbstractModel
    {
        
        /// <summary>
        /// [查询结果]查询结果；枚举值：0 查询成功，否则查询失败
        /// </summary>
        [JsonProperty("ResultCode")]
        public long? ResultCode{ get; set; }

        /// <summary>
        /// [固定信息]响应协议版本号；
        /// </summary>
        [JsonProperty("RespVer")]
        public long? RespVer{ get; set; }

        /// <summary>
        /// [查询结果]url恶意状态；枚举值：1-灰， 2-黑（具体的恶意类型参考恶意类型定义Eviltype字段) ，3-非腾讯白名单，4-腾讯白名单。查询结果（level、evilclass、eviltype）这3个字段在Urltype=2（url状态为黑）下才有意义。
        /// </summary>
        [JsonProperty("UrlType")]
        public long? UrlType{ get; set; }

        /// <summary>
        /// [查询结果]url恶意大类；枚举值：1-链接，2-Cgi，3-路劲，4-整站，5-整域。
        /// </summary>
        [JsonProperty("EvilClass")]
        public long? EvilClass{ get; set; }

        /// <summary>
        /// [查询结果]url恶意类型；枚举值：1-社工欺诈（仿冒、账号钓鱼、中奖诈骗）；2-信息诈骗（虚假充值、虚假兼职、虚假金融投资、虚假信用卡代办、网络赌博诈骗；3-虚假销售（男女保健美容减肥产品、电子产品、虚假广告、违法销售）；4-恶意文件（病毒文件，木马文件，恶意apk文件的下载链接以及站点，挂马网站）；5-博彩网站（博彩网站，在线赌博网站）；6-色情网站（涉嫌传播色情内容，提供色情服务的网站；7-风险网站（弱类型，传播垃圾信息的网站, 如果客户端有阻断，不建议使用这个数据）；8-非法内容（根据法律法规不能传播的内容，主要为政治敏感内容，默认内部使用）
        /// </summary>
        [JsonProperty("EvilType")]
        public long? EvilType{ get; set; }

        /// <summary>
        /// [查询结果]url恶意级别
        /// </summary>
        [JsonProperty("Level")]
        public long? Level{ get; set; }

        /// <summary>
        /// [查询详情]url检出时间
        /// </summary>
        [JsonProperty("DetectTime")]
        public long? DetectTime{ get; set; }

        /// <summary>
        /// [查询详情]拦截Wording
        /// </summary>
        [JsonProperty("Wording")]
        public string Wording{ get; set; }

        /// <summary>
        /// [查询详情]拦截Wording 标题
        /// </summary>
        [JsonProperty("WordingTitle")]
        public string WordingTitle{ get; set; }

        /// <summary>
        /// [查询结果]url恶意状态说明
        /// </summary>
        [JsonProperty("UrlTypeDesc")]
        public string UrlTypeDesc{ get; set; }

        /// <summary>
        /// [查询结果]url恶意大类说明
        /// </summary>
        [JsonProperty("EvilClassDesc")]
        public string EvilClassDesc{ get; set; }

        /// <summary>
        /// [查询结果]url恶意类型说明
        /// </summary>
        [JsonProperty("EvilTypeDesc")]
        public string EvilTypeDesc{ get; set; }

        /// <summary>
        /// [查询结果]url恶意级别说明
        /// </summary>
        [JsonProperty("LevelDesc")]
        public string LevelDesc{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResultCode", this.ResultCode);
            this.SetParamSimple(map, prefix + "RespVer", this.RespVer);
            this.SetParamSimple(map, prefix + "UrlType", this.UrlType);
            this.SetParamSimple(map, prefix + "EvilClass", this.EvilClass);
            this.SetParamSimple(map, prefix + "EvilType", this.EvilType);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "DetectTime", this.DetectTime);
            this.SetParamSimple(map, prefix + "Wording", this.Wording);
            this.SetParamSimple(map, prefix + "WordingTitle", this.WordingTitle);
            this.SetParamSimple(map, prefix + "UrlTypeDesc", this.UrlTypeDesc);
            this.SetParamSimple(map, prefix + "EvilClassDesc", this.EvilClassDesc);
            this.SetParamSimple(map, prefix + "EvilTypeDesc", this.EvilTypeDesc);
            this.SetParamSimple(map, prefix + "LevelDesc", this.LevelDesc);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

