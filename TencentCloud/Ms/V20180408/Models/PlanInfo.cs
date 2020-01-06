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

    public class PlanInfo : AbstractModel
    {
        
        /// <summary>
        /// apk大小优化，0关闭，1开启
        /// </summary>
        [JsonProperty("ApkSizeOpt")]
        public ulong? ApkSizeOpt{ get; set; }

        /// <summary>
        /// Dex加固，0关闭，1开启
        /// </summary>
        [JsonProperty("Dex")]
        public ulong? Dex{ get; set; }

        /// <summary>
        /// So加固，0关闭，1开启
        /// </summary>
        [JsonProperty("So")]
        public ulong? So{ get; set; }

        /// <summary>
        /// 数据收集，0关闭，1开启
        /// </summary>
        [JsonProperty("Bugly")]
        public ulong? Bugly{ get; set; }

        /// <summary>
        /// 防止重打包，0关闭，1开启
        /// </summary>
        [JsonProperty("AntiRepack")]
        public ulong? AntiRepack{ get; set; }

        /// <summary>
        /// Dex分离，0关闭，1开启
        /// </summary>
        [JsonProperty("SeperateDex")]
        public ulong? SeperateDex{ get; set; }

        /// <summary>
        /// 内存保护，0关闭，1开启
        /// </summary>
        [JsonProperty("Db")]
        public ulong? Db{ get; set; }

        /// <summary>
        /// Dex签名校验，0关闭，1开启
        /// </summary>
        [JsonProperty("DexSig")]
        public ulong? DexSig{ get; set; }

        /// <summary>
        /// So文件信息
        /// </summary>
        [JsonProperty("SoInfo")]
        public SoInfo SoInfo{ get; set; }

        /// <summary>
        /// vmp，0关闭，1开启
        /// </summary>
        [JsonProperty("AntiVMP")]
        public ulong? AntiVMP{ get; set; }

        /// <summary>
        /// 保护so的强度，
        /// </summary>
        [JsonProperty("SoType")]
        public string[] SoType{ get; set; }

        /// <summary>
        /// 防日志泄漏，0关闭，1开启
        /// </summary>
        [JsonProperty("AntiLogLeak")]
        public ulong? AntiLogLeak{ get; set; }

        /// <summary>
        /// root检测，0关闭，1开启
        /// </summary>
        [JsonProperty("AntiQemuRoot")]
        public ulong? AntiQemuRoot{ get; set; }

        /// <summary>
        /// 资源防篡改，0关闭，1开启
        /// </summary>
        [JsonProperty("AntiAssets")]
        public ulong? AntiAssets{ get; set; }

        /// <summary>
        /// 防止截屏，0关闭，1开启
        /// </summary>
        [JsonProperty("AntiScreenshot")]
        public ulong? AntiScreenshot{ get; set; }

        /// <summary>
        /// SSL证书防窃取，0关闭，1开启
        /// </summary>
        [JsonProperty("AntiSSL")]
        public ulong? AntiSSL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApkSizeOpt", this.ApkSizeOpt);
            this.SetParamSimple(map, prefix + "Dex", this.Dex);
            this.SetParamSimple(map, prefix + "So", this.So);
            this.SetParamSimple(map, prefix + "Bugly", this.Bugly);
            this.SetParamSimple(map, prefix + "AntiRepack", this.AntiRepack);
            this.SetParamSimple(map, prefix + "SeperateDex", this.SeperateDex);
            this.SetParamSimple(map, prefix + "Db", this.Db);
            this.SetParamSimple(map, prefix + "DexSig", this.DexSig);
            this.SetParamObj(map, prefix + "SoInfo.", this.SoInfo);
            this.SetParamSimple(map, prefix + "AntiVMP", this.AntiVMP);
            this.SetParamArraySimple(map, prefix + "SoType.", this.SoType);
            this.SetParamSimple(map, prefix + "AntiLogLeak", this.AntiLogLeak);
            this.SetParamSimple(map, prefix + "AntiQemuRoot", this.AntiQemuRoot);
            this.SetParamSimple(map, prefix + "AntiAssets", this.AntiAssets);
            this.SetParamSimple(map, prefix + "AntiScreenshot", this.AntiScreenshot);
            this.SetParamSimple(map, prefix + "AntiSSL", this.AntiSSL);
        }
    }
}

